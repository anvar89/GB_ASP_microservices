using MetricsManager.Controllers;
using MetricsManager.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class RamMetricsControllerTests
    {
        private RamMetricsController controller;

        public RamMetricsControllerTests()
        {
            controller = new RamMetricsController();
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
            int agentId = 1;
            DateTimeOffset from = DateTimeOffset.MinValue;
            DateTimeOffset to = DateTimeOffset.MaxValue;

            var result = controller.GetMetricsByPercentileFromAllCluster(from, to, p);
        }

    }
}
