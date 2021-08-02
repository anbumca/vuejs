using Access2._0_POC.Models;
using EntityLibrary.Context;
using Generic.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Access2._0_POC.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {

        }

        [HttpPost("Login")]
        public IActionResult Login(DynamicForm record)
        {
            try
            {
                var userObj = new User();
                ConvertGeneric cvrt = new ConvertGeneric();
                userObj = (User)cvrt.GenerateModel(record.sections[0], userObj);
                return Ok();
            }
            catch
            {
                return Problem(statusCode: 400, title: "Unable to process the request!", type: "Error");
            }
        }
    }
}
