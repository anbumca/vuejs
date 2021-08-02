using Generic.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/22/2021 4:47:00 PM 
*/

namespace Generic.Model
{
    interface IConvertGeneric
    {
        object GenerateModel(object JsonObject, object EntityModel);
    }
}
