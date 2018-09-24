using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_version_test.Controllers
{
    [Route("foo")]
    [Route("v{api-version:apiVersion}/foo")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    public class FooController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<string> Get(){
            return "v1";
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public ActionResult<string> GetV1(){
            return "v2";
        }

        [HttpGet("squared/{number}")]
        [MapToApiVersion("2.0")]
        public ActionResult<string> Squared(int number){
            return (number * number).ToString();
        }
    }
}
