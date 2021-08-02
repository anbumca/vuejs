using Job.Console.Services.IServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/19/2021 9:53:08 PM 
*/

namespace Job.Console.LMSLearningCourseCategoryJob
{
    public class CourseCategoryJob
    {
        private ILMSLearningCategory _lmsLearningCategoryService;

        public CourseCategoryJob(ServiceProvider serviceProvider)
        {
            _lmsLearningCategoryService = serviceProvider.GetService<ILMSLearningCategory>();
        }

        public bool InsertUpdateFromDoceboAPI()
        {
            try
            {
                return _lmsLearningCategoryService.InsertUpdateFromDoceboAPI();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e);
                return false;
            }
        }
    }
}
