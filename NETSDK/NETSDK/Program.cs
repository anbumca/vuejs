//using Sitecore.LayoutService.Client.Request;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NETSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            //SitecoreLayoutRequest Request = new SitecoreLayoutRequest();
           //var s= Request.ApiKey();
            Console.WriteLine("Hello World!");
            //Person person1 = new Person();
            var obj =Activator.CreateInstance(Assembly.GetExecutingAssembly().GetName().Name,
                Assembly.GetExecutingAssembly().GetName().Name+".Person");
            var person= obj.Unwrap();
            AssignValues(person);
        }

        private static object AssignValues(object obj)
        {
            var s1= new List<PersonLite>() {

                new PersonLite()
            {
                FieldName = "FirstName",
                FieldType= "string",
                FieldValue ="Yesu"

            },
                 new PersonLite()
            {
                FieldName = "LastName",
                FieldType= "string",
                FieldValue ="c"

            },
                 new PersonLite()
            {
                FieldName = "Age",
                FieldType= "int",
                FieldValue ="25"

            },
                      new PersonLite()
            {
                FieldName = "Male",
                FieldType= "bool",
                FieldValue ="true"

            }

                };

            foreach (var s in s1)
            {
                var p1 = s.FieldName;
                var v1 = s.FieldValue;
                string t1 = s.FieldType;

                switch (t1)
                {
                    case "bool":
                        {
                            obj.GetType().GetProperty(p1).SetValue(obj, Convert.ChangeType(v1,typeof(bool)));
                            break;
                        }
                    case "int":
                        {
                            obj.GetType().GetProperty(p1).SetValue(obj, Convert.ChangeType(v1, typeof(int)));
                            break;
                        }
                    default:
                        {
                            obj.GetType().GetProperty(p1).SetValue(obj, v1);
                            break;
                        }
                }
                
            }

            return obj;
        }
    }


}
