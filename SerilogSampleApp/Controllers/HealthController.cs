using Microsoft.AspNetCore.Mvc;

namespace SerilogSampleApp.Controllers
{
    [Route("health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok("Server is happy");
        }
    }
}