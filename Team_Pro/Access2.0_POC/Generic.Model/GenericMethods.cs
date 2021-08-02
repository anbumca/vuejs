using Generic.Model.Helpers;
using System;
using System.Reflection;

namespace Generic.Model
{
    public class GenericMethods
    {
    }

    public static class CreateModel
    {


        public static object GenerateModel(object JsonObject, string TargetObject)
        {
            if (JsonObject == null)
                throw new NullReferenceException("JSON Object is passed as null");

            //convert json object to typed object
            JsonModel jsonObj = new JsonModel();
            jsonObj = (JsonModel)JsonObject;

            object obj = GetEntityObject(TargetObject);

            if (obj == null)
                throw new NullReferenceException("Target EntityModel not found");

            foreach(var itm in jsonObj.sections)
            {
                foreach(var inItm in itm.elements)
                {
                    var fieldName = inItm.elementname;
                    var fieldValue = inItm.elementfieldvalue;
                    var fieldType = inItm.serverobjecttype;

                    var targetProperty = obj.GetType().GetProperty(fieldName);

                    if(targetProperty == null)
                        throw new NullReferenceException($"Target Property {fieldName} not found");

                    targetProperty.SetValue(obj, fieldValue, null);
                }
            }

            return obj;
        }

        private static object GetEntityObject(string EntityName)
        {
            try
            {
                var obj = Activator.CreateInstance(Assembly.GetExecutingAssembly().GetName().Name,
                     Assembly.GetExecutingAssembly().GetName().Name + $".{EntityName}");

                return obj;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
