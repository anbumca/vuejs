using System;
using System.Collections.Generic;
using System.Text;
using EntityLibrary.Context;
using Job.Console.Services.IServices;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Job.Console.Models.LearningCourseCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

/**
* @author udhayakumar_m
*
* @date - 7/19/2021 1:04:16 PM 
*/

namespace Job.Console.Services
{
    public class LMSLearningCategoryService : ILMSLearningCategory
    {
        private IAuth _auth;
        private AccessDbContext _context;

        public LMSLearningCategoryService(IAuth Auth, AccessDbContext Context)
        {
            _auth = Auth;
            _context = Context;
        }

        public bool Add(LMSLearningCourseCategory record)
        {
            try
            {

                return true;
            }
            catch(Exception e)
            {
                System.Console.Write(e);
                return false;
            }
        }


        public bool InsertUpdateFromDoceboAPI()
        {
            try
            {
                var records = _context.Currency.ToList();
                var token = _auth.AcquireAccessToken("WSFAuthSSOTest", "guillaume.vincent@loreal.com", Environment.GetEnvironmentVariable("PrivateKey"), null).Result;

                if(token != null && token.AccessToken != null)
                {
                    using(var client=new HttpClient())
                    {
                        var requestURI = Environment.GetEnvironmentVariable("CourseCategoryURI");

                        client.BaseAddress = new Uri($"{requestURI}");

                        // Add an Accept header for JSON format.
                        client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.AccessToken}");

                        HttpResponseMessage response = client.GetAsync("categories?page=1&page_size=10").GetAwaiter().GetResult();

                        if (!response.IsSuccessStatusCode)
                        {
                            return false;
                        }

                        var responseString = response.Content.ReadAsStringAsync().Result;

                        var responseObject = JsonConvert.DeserializeObject<CourseCategoryResponseModel>(responseString);

                        if(responseObject != null && responseObject.data != null && responseObject.data.items != null)
                        {
                            foreach(var itm in responseObject.data.items)
                            {
                                try
                                {
                                    var result = _context.Add_LMSMainCategory.FromSqlRaw("exec Add_LMSMainCategory {0}, {1}, {2}, {3}", itm.id, null, itm.title, null).ToList();
                                }
                                catch(Exception)
                                {

                                }
                            }
                        }
                    }

                    return true;
                }

                return false;
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
                return false;
            }
        }
    }
}
