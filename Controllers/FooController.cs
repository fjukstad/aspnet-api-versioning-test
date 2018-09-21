using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_version_test.Controllers
{
    [Route("v{version:apiVersion}/foo")]
    [ApiVersion("1.0")]
    [ApiController]
    public class FooController : ControllerBase
    {
        [HttpGet("{version}")]
        public ActionResult<string> ExistingAction([FromRoute] int version){
            return version.ToString();
        }
    }
}
