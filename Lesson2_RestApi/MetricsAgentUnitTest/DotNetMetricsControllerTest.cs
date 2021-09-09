using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MetricsAgentUnitTest
{
    public class DotNetMetricsControllerTest
    {
        private DotNetMetricsController controller;

        public DotNetMetricsControllerTest()
        {
            controller = new DotNetMetricsController();
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
