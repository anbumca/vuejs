using Access2._0_POC.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLibrary.Context;

namespace Access2._0_POC.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicFormController : ControllerBase
    {
        private IDynamicForm _dynamic;


        public DynamicFormController(IDynamicForm Dynamic)
        {
            _dynamic = Dynamic;
        }

        [HttpGet("GetFormElements")]
        public IActionResult GetDynamic(int pageid, int countryid, int tenantid, int languageid)
        {
            var result = _dynamic.GetDynamic(pageid, countryid, tenantid, languageid);

            if (result == null)
                return Problem(statusCode: 400, title: "Unable to process the request!", type: "Error");
            else
                return Ok(result);
        }


    }
}
