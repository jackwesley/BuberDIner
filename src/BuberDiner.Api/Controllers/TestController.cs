using BubaDinner.Application.Services.Interfaces;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace BuberDiner.Api.Controllers
{
    [Route("[controller]")]
    public class TestController : ApiController
    {
        private readonly ITest _test;
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, ITest test)
        {
            _logger = logger;
            _test = test;
        }

        [HttpGet]
        [Route("{message}")]
        public IActionResult Get(string message)
        {
            ErrorOr<string> result = _test.HandleTest(message);

            return result.Match(
                response => Ok(response),
                errors => Problem(errors));
        }
    }
}