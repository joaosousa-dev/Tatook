using Microsoft.AspNetCore.Mvc;

namespace Tatook.API.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("Ping")]
        public IActionResult HealthCheck()
        {
            return Ok(new { Message = "Pong" });
        }
    }
}
