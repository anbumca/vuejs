using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/19/2021 9:15:59 PM 
*/

namespace Job.Console.DoceboHelper
{
    public class DoceboAccessToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
