using MetricsManager.Controllers;
using MetricsManager.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class HddMetricsControllerTests
    {
        private HddMetricsController controller;

        public HddMetricsControllerTests()
        {
            controller = new HddMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_test()
        {
            int agentId = 1;
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetricsFromAgent(agentId, from, to);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsByPercentileFromAgent_test()
        {
            Percentile p = Percentile.P90;
            int agentId = 1;
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetricsByPercentileFromAgent(agentId, from, to, p);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromAllCluster_test()
        {
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetricsFromAllCluster(from, to);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsByPercentileFromAllCluster_test()
        {
            Percentile p = Percentile.P75;
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetricsByPercentileFromAllCluster(from, to, p);
        }

    }
}
