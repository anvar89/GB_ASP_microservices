using MetricsManager.Controllers.AgentsController;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MetricsManagerUnitTests
{
    public class AgentsControllerTests
    {
        private AgentsController controller;

        public AgentsControllerTests()
        {
            controller = new AgentsController();
        }

        [Fact]
        public void RegisterAgent_Test()
        {
            AgentInfo testAgent = new AgentInfo();

            var result = controller.RegisterAgent(testAgent);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_Test()
        {
            int id = 100;

            var result = controller.EnableAgentById(id);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById_Test()
        {
            int id = 100;

            var result = controller.EnableAgentById(id);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }

}
