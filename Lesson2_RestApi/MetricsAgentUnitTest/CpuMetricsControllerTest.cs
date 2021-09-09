using MetricsAgent.Controllers;
using MetricsManager.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentUnitTest
{
    public class CpuMetricsControllerTest
    {
        private CpuMetricsController controller;

        public CpuMetricsControllerTest()
        {
            controller = new CpuMetricsController();
        }

        [Fact]
        public void GetMetrics_from_to_percentile_Test()
        {
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;
            Percentile p = Percentile.P75;

            var result = controller.GetMetrics(from, to, p);

            Assert.IsAssignableFrom<IActionResult>(result);

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


