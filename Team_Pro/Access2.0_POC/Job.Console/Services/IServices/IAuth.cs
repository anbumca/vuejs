using Job.Console.DoceboHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/**
* @author udhayakumar_m
*
* @date - 7/19/2021 1:30:30 PM 
*/

namespace Job.Console.Services.IServices
{
    public interface IAuth
    {
        Task<DoceboAccessToken> AcquireAccessToken(string clientApplicationId, string userId, string certificateFilePath, string certificateFileContent);
    }
}
