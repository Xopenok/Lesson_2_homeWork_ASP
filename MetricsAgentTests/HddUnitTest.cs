using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class HddUnitTest
    {
        private HddController _controller;

        public HddUnitTest()
        {
            _controller = new();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            TimeSpan timeFrom = TimeSpan.FromSeconds(0);
            TimeSpan timeTo = TimeSpan.FromSeconds(100);

            var result = _controller.GetMetric(timeFrom, timeTo);

            Assert.IsAssignableFrom<IActionResult>(result);

        }
    }
}
