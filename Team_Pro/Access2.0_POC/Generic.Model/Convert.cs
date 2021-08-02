using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Generic.Model.Helpers;
using System.Linq;
using Newtonsoft.Json;
using EntityLibrary.Context;
using System.Dynamic;

/**
* @author udhayakumar_m
*
* @date - 7/22/2021 4:51:32 PM 
*/

namespace Generic.Model
{
    public class ConvertGeneric : IConvertGeneric
    {
        /// <summary>
        /// This will return your defined entity model along with filled data
        /// </summary>
        /// <param name="JsonObject">This is the section part in the JSON model object</param>
        /// <param name="TargetObject">Provide the target entity model object which should be available in the EntityLibrary Namespace</param>
        /// <returns></returns>
        public object GenerateModel(object JsonObject, object EntityModel)
        {
            var jsonObj = JsonConvert.DeserializeObject<Sections>(JsonConvert.SerializeObject(JsonObject));

            object obj = EntityModel; // GetEntityObject(EntityModel);

            if (obj == null)
                throw new NullReferenceException("Target EntityModel not found");

            foreach (var inItm in jsonObj.elements)
            {
                if (string.IsNullOrEmpty(inItm.elementname) || string.IsNullOrEmpty(inItm.elementfieldvalue))
                    throw new NullReferenceException("JSON Object element name/value should not be empty!");

                var propertyInfo = obj.GetType().GetProperty(inItm.elementname);

                if (propertyInfo != null)
                {
                    if (Nullable.GetUnderlyingType(propertyInfo.PropertyType) == null)
                        propertyInfo.SetValue(obj, Convert.ChangeType(inItm.elementfieldvalue, propertyInfo.PropertyType), null);
                    else
                        propertyInfo.SetValue(obj, Convert.ChangeType(inItm.elementfieldvalue, Nullable.GetUnderlyingType(propertyInfo.PropertyType)), null);
                }
            }

            return obj;
        }


        private static object GetEntityObject(string EntityName)
        {
            var targetAssembly = Assembly.GetAssembly(typeof(AccessDbContext));

            var obj = Activator.CreateInstance(targetAssembly.GetName().Name,
                 targetAssembly.GetName().Name + $".{EntityName}").Unwrap();

            return obj;
        }
    }
}
