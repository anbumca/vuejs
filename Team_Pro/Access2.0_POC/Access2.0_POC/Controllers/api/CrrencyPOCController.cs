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
    public class CrrencyPOCController : ControllerBase
    {
        private ICurrency _currency;
        private ISubscriptionPlan _subscriptionPlan;

        public CrrencyPOCController(ICurrency Currency, ISubscriptionPlan subscriptionPlan)
        {
            _currency = Currency;
            _subscriptionPlan = subscriptionPlan;
        }

        [HttpGet("Get")]
        public IActionResult GetCurrency()
        {
            var result = _currency.Get();

            if (result == null)
                return Problem(statusCode: 400, title: "Unable to process the request!", type: "Error");
            else
                return Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult AddCurrency(Currency input)
        {
            var result = _currency.Add(input);

            if(result.Key)
                return Problem(statusCode: 200, title: "Successfully addded!", type: "Success!");
            else
                return Problem(statusCode: 400, title: result.Value, type: "Error");
        }

        [HttpPost("Update")]
        public IActionResult UpdateCurrency(Currency input)
        {
            var result = _currency.Update(input);

            if (result.Key)
                return Problem(statusCode: 200, title: "Successfully updated!", type: "Success!");
            else
                return Problem(statusCode: 400, title: result.Value, type: "Error");
        }

        [HttpPost("AddSubscription")]
        public IActionResult AddSubscription(SubscriptionPlan subscriptionPlan)
        {
            var result = _subscriptionPlan.Add(subscriptionPlan);

            if (result.Key)
                return Problem(statusCode: 200, title: "Successfully addded!", type: "Success!");
            else
                return Problem(statusCode: 400, title: result.Value, type: "Error");

        }
    }
}
