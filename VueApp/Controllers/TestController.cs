using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VueApp.Controllers
{
    [ApiController]
    [Route( "api/[controller]" )]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController( ILogger<TestController> logger )
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok( new
            {
                Value = 42
            } );
        }
    }
}
