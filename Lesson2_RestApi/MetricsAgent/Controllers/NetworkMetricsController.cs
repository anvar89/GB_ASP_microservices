using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class NetworkMetricsController : ControllerBase
    {
        [HttpGet("from/{from}/to/{to}")]
        public IActionResult GetMetrics([FromRoute] DateTimeOffset from, [FromRoute] DateTimeOffset to)
        {
            return Ok();
        }
    }
}
