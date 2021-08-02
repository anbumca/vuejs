using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Job.Console.DoceboHelper;
using Job.Console.Helper;
using Job.Console.Services.IServices;
using Newtonsoft.Json;

/**
* @author udhayakumar_m
*
* @date - 7/19/2021 1:30:38 PM 
*/

namespace Job.Console.Services
{
    public class AuthService : IAuth
    {
        public async Task<DoceboAccessToken> AcquireAccessToken(string clientApplicationId, string userId, string certificateFilePath, string certificateFileContent)
        {
            try
            {
                System.Console.WriteLine("Start AcquireAccessToken");

                JWTHelper jwtHelper = new JWTHelper();

                var jwtToken = jwtHelper.GenerateJWToken(clientApplicationId, userId, certificateFilePath, certificateFileContent);
                if (string.IsNullOrEmpty(jwtToken))
                    throw new Exception($"Unable to authenticate the user {userId}");

                System.Console.WriteLine($"jwtToken: {jwtToken}");
                System.Console.WriteLine("Launch GetDoceboAccessToken");
                return await GetDoceboAccessToken(jwtToken);

            }
            catch(Exception e)
            {
                System.Console.Write(e);
                return null;
            }
        }
        private async static Task<DoceboAccessToken> GetDoceboAccessToken(string jwtToken)
        {
            System.Console.WriteLine("Start GetDoceboAccessToken");
            DoceboAccessToken accessTokenResult = null;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"{Environment.GetEnvironmentVariable("DoceboApiServiceUrl")}/oauth2/token"))
                {
                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new StringContent("urn:ietf:params:oauth:grant-type:jwt-bearer"), "grant_type");
                    multipartContent.Add(new StringContent("api"), "scope");
                    multipartContent.Add(new StringContent(jwtToken), "assertion");
                    request.Content = multipartContent;

                    var httpResponse = httpClient.SendAsync(request).GetAwaiter().GetResult();


                    if (httpResponse != null)
                    {
                        httpResponse.EnsureSuccessStatusCode();
                        if (httpResponse.Content != null && httpResponse.Content is object
                            && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
                        {
                            var contentStream = await httpResponse.Content.ReadAsStreamAsync();
                            using (var streamReader = new StreamReader(contentStream))
                            {
                                using (var jsonReader = new JsonTextReader(streamReader))
                                {
                                    JsonSerializer serializer = new JsonSerializer();

                                    try
                                    {
                                        accessTokenResult = serializer.Deserialize<DoceboAccessToken>(jsonReader);
                                    }
                                    catch (JsonReaderException)
                                    {
                                        System.Console.WriteLine("Invalid JSON.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
                        }
                    }
                }
            }

            return accessTokenResult;
        }

    }
}
