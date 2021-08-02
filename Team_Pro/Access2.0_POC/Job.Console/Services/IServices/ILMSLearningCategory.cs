using System;
using System.Collections.Generic;
using System.Text;
using EntityLibrary.Context;

namespace Job.Console.Services.IServices
{
    public interface ILMSLearningCategory
    {
        bool Add(LMSLearningCourseCategory record);

        bool InsertUpdateFromDoceboAPI();
    }
}
