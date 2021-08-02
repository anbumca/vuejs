using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access2._0_POC.Models;
//using ContextDynamic = EntityLibrary.Context.Dynamic;
using EntityLibrary.Context;

namespace Access2._0_POC.Services.IServices
{
    public interface IDynamicForm
    {
        DynamicForm GetDynamic(int pageid, int countryid, int tenantid, int languageid);
    }
}
