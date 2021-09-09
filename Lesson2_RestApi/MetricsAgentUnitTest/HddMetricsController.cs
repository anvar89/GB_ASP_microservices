using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MetricsAgentUnitTest
{
    public class HddMetricsControllerTest
    {
        HddMetricsController controller;

        public HddMetricsControllerTest()
        {
            controller = new HddMetricsController();
        }

        [Fact]
        public void GetMetrics_left_Test()
        {
            long left = 1024;

            var result = controller.GetMetrics(left);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
