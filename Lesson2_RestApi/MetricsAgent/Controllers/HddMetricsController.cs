using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("left/{left}")]
        public IActionResult GetMetrics([FromRoute] long left)
        {
            return Ok();
        }
    }
}
