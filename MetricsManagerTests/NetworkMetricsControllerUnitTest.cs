using Manager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
    public class NetworkMetricsControllerUnitTest
    {
        private NetworkMetricsController _controller;

        public NetworkMetricsControllerUnitTest()
        {
            _controller = new();
        }

        [Fact]
        public void GetMetricsFromAgentByPeriod_ReturnsOk()
        {
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(10);

            var result = _controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromClusterByPeriod_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(10);

            var result = _controller.GetMetricsFromCluster(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromAgentByAllTime_ReturnsOk()
        {
            var agentId = 1;

            var result = _controller.GetMetricsFromAgent(agentId);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromClusterByAllTime_ReturnsOk()
        {
            var result = _controller.GetMetricsFromCluster();

            Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
