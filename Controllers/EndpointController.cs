using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_version_test.Controllers
{
    [Route("v{version:apiVersion}/endpoint")]
    [ApiVersion("0.9")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    public class EndpointController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("2.0")]
        public ActionResult<string> GetV2()
        {
            return "version 2";
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<string> GetV1()
        {
            return "version 1";
        }

        [HttpGet]
        [MapToApiVersion("0.9")]
        public ActionResult<string> GetV0()
        {
            return "version 0.9";
        }
    }
}
