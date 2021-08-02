using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access2._0_POC.Services.IServices;
using EntityLibrary.Context;

namespace Access2._0_POC.Controllers.api
{
    [Route("api/ExternalEcom/[controller]")]
    [ApiController]
    public class POCController : ControllerBase
    {
        private IExternalEcomSystem _externalEcom;
        public POCController(IExternalEcomSystem ExternalEcom)
        {
            _externalEcom = ExternalEcom;
        }

        [HttpGet("Get")]
        public IActionResult GetExternalEcom()
        {
            var result = _externalEcom.Get();

            if (result == null)
                return Problem(statusCode: 400, title: "Unable to process the request!", type: "Error");
            else
                return Ok(result.ToList());
        }

        [HttpPost("Add")]
        public IActionResult AddExternalEcom([FromBody] ExternalEcommSystem input)
        {
            var result = _externalEcom.Add(input);

            if (result.Key)
                return Problem(statusCode: 200, title: "Successfully addded!", type: "Success!");
            else
                return Problem(statusCode: 400, title: result.Value, type: "Error");
        }

        [HttpPost("Update")]
        public IActionResult UpdateExternalEcom([FromBody] ExternalEcommSystem input)
        {
            var result = _externalEcom.Update(input);

            if (result.Key)
                return Problem(statusCode: 200, title: "Successfully updated!", type: "Success!");
            else
                return Problem(statusCode: 400, title: result.Value, type: "Error");
        }


    }
}
