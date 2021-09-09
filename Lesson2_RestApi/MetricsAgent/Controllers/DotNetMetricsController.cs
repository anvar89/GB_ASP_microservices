using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        [HttpGet("error-count/from/{from}/to/{to}")]
        public IActionResult GetMetrics([FromRoute] DateTimeOffset from, [FromRoute] DateTimeOffset to)
        {
            return Ok();
        }
    }
}
