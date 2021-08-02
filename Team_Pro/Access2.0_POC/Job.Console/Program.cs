using EntityLibrary.Context;
using Job.Console.Services.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Job.Console.Services;
using Job.Console.LMSLearningCourseCategoryJob;
using Generic.Model;
using Job.Console.Models;
using System.Collections.Generic;

namespace Job.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic method test
            JsonModel genObj = new JsonModel()
            {
                sections = new List<Sections>()
            };

            Sections scs = new Sections
            {
                elements = new List<Elements>()
            };

            List<Elements> elm = new List<Elements>()
            {
                new Elements()
                {
                    elementname = "user_name",
                    elementfieldvalue = "udhayakumar.m@photon.in"
                },
                new Elements()
                {
                    elementname = "firstname",
                    elementfieldvalue = "Udhayakumar"
                },
                new Elements()
                {
                    elementname = "lastname",
                    elementfieldvalue = "Mothilal"
                },
                new Elements()
                {
                    elementname = "email",
                    elementfieldvalue = "udhayakumar.m@photon.in"
                },
                new Elements()
                {
                    elementname = "created_at",
                    elementfieldvalue = DateTime.Now.ToString()
                },
                new Elements()
                {
                    elementname = "internal_id",
                    elementfieldvalue = "10"
                },
                new Elements()
                {
                    elementname = "is_global_admin",
                    elementfieldvalue = "true"
                }
            };
            scs.elements.AddRange(elm);

            genObj.sections.Add(scs);

            ConvertGeneric cvrt = new ConvertGeneric();
            var userObj = new User();
            userObj = (User)cvrt.GenerateModel(genObj.sections[0], userObj);

            var DBHost = Environment.GetEnvironmentVariable("DBHost");
            var DBPassword = Environment.GetEnvironmentVariable("DBPassword");
            var DBUser = Environment.GetEnvironmentVariable("DBUser");

            var services = new ServiceCollection();

            services.AddTransient<IAuth, AuthService>();
            services.AddTransient<ILMSLearningCategory, LMSLearningCategoryService>();

            services.AddDbContext<AccessDbContext>
                (item => item.UseLazyLoadingProxies().UseSqlServer($"Server={DBHost};User Id=access;Password=Access@123;Database=AccessDB"));

            var serviceProvider = services.BuildServiceProvider();

            var obj = new CourseCategoryJob(serviceProvider);

            var status = obj.InsertUpdateFromDoceboAPI();

            System.Console.WriteLine("Hello World!");
        }
    }
}
