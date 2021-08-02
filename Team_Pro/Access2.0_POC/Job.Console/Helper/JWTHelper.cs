using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


/*
* @author udhayakumar_m
*
* @date - 7/19/2021 8:41:56 PM 
*/

namespace Job.Console.Helper
{
    public class JWTHelper : RSAHelper
    {

        private string GenerateJWT(string privateSecretKey, string clientID, string userName)
        {
            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            RSAHelper rsaHelper = new RSAHelper();

            rsa = DecodeRSAPrivateKey(FromBase64Url(privateSecretKey));

            //convert to csp format
            var bytes = rsa.ExportCspBlob(false);
            var publicKey = Convert.ToBase64String(bytes);

            // Get Signing Key & Generate Signing Credentials
            RsaSecurityKey _signingKey = new RsaSecurityKey(rsa);
            Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials =
                   new Microsoft.IdentityModel.Tokens.SigningCredentials(_signingKey, SecurityAlgorithms.RsaSha256);

            // Build Head
            JwtHeader head = new JwtHeader(signingCredentials);


            string sNewGuid = Guid.NewGuid().ToString("n");

            var claims = new[]
                  {
              new Claim(JwtRegisteredClaimNames.Iss, clientID),
              new Claim(JwtRegisteredClaimNames.Sub, userName),
              new Claim(JwtRegisteredClaimNames.Aud, "loreal-ppdstaging.docebosaas.com"),
              //new Claim(JwtRegisteredClaimNames.Jti,  sNewGuid),
              new Claim(JwtRegisteredClaimNames.Exp, ((Int64)DateTime.Now.AddMinutes(55).Subtract(UnixEpoch).TotalSeconds).ToString(System.Globalization.CultureInfo.InvariantCulture), ClaimValueTypes.Integer64),
              new Claim(JwtRegisteredClaimNames.Iat, ((Int64)DateTime.Now.Subtract(UnixEpoch).TotalSeconds).ToString(System.Globalization.CultureInfo.InvariantCulture), ClaimValueTypes.Integer64)
          };


            JwtPayload payload = new JwtPayload(claims);
            JwtSecurityToken jwt = new JwtSecurityToken(head, payload);
            jwt.SigningKey = _signingKey;
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return encodedJwt;
        }


        public string GenerateJWToken(string clientID, string username, string privateKeyFilePath, string privateKeyFileContent)
        {
            System.Console.WriteLine("Start GenerateJWToken");
            var privateKey = !string.IsNullOrEmpty(privateKeyFilePath) ? System.IO.File.ReadAllText(privateKeyFilePath) : privateKeyFileContent;
            privateKey = privateKey.Replace("-----BEGIN RSA PRIVATE KEY-----\r\n", "").Replace("\r\n-----END RSA PRIVATE KEY-----", "");
            privateKey = privateKey.Replace("-", "+").Replace("_", "/");

            System.Console.WriteLine($"privateKey: {privateKey}");

            JWTHelper svc = new JWTHelper();

            System.Console.WriteLine("Launch GenerateJWT");
            var jwtToken = svc.GenerateJWT(privateKey, clientID, username);
            return jwtToken;
        }

        private static byte[] FromBase64Url(string base64Url)
        {
            string base64 = string.Empty;
            if (!string.IsNullOrEmpty(base64Url))
            {
                string padded = base64Url.Length % 4 == 0
                    ? base64Url : base64Url + "====".Substring(base64Url.Length % 4);
                base64 = padded.Replace("_", "/")
                                        .Replace("-", "+");
            }
            return Convert.FromBase64String(base64);
        }
    }
}
