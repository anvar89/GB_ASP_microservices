using MetricsManager.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        [HttpGet("from/{from}/to/{to}/percentiles/{percentile}")]
        public IActionResult GetMetrics([FromRoute] DateTimeOffset from, [FromRoute] DateTimeOffset to, [FromRoute] Percentile percentile)
        {
            return Ok();
        }

        [HttpGet("from/{from}/to/{to}")]
        public IActionResult GetMetrics([FromRoute] DateTimeOffset from, [FromRoute] DateTimeOffset to)
        {
            return Ok();
        }
    }
}

