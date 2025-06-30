using Microsoft.AspNetCore.Mvc;
using TransbankSdkDotnetExample.Controllers;

namespace Tests
{
    public class DummyControllerTests
    {
        [Fact]
        public void Ping_ReturnsOkResult()
        {
            var controller = new DummyController();
            var result = controller.Ping();
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("pong", okResult.Value);
        }
    }
}
