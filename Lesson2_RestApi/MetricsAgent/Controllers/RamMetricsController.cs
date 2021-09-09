using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/ram")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("available/{available}")]
        public IActionResult GetMetrics([FromRoute] long available)
        {
            return Ok();
        }
    }
}
