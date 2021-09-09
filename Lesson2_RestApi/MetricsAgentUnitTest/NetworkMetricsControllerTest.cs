using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentUnitTest
{
    public class NetworkMetricsControllerTest
    {
        private NetworkMetricsController controller;

        public NetworkMetricsControllerTest()
        {
            controller = new NetworkMetricsController();
        }

        [Fact]
        public void GetMetrics_from_to_Test()
        {
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetrics(from, to);

            Assert.IsAssignableFrom<IActionResult>(result);

        }
    }
}
