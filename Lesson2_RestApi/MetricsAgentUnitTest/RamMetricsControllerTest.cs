using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MetricsAgentUnitTest
{
    public class RamMetricsControllerTest
    {
        RamMetricsController controller;

        public RamMetricsControllerTest()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetrics_available_Test()
        {
            long available = 1024;

            var result = controller.GetMetrics(available);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
