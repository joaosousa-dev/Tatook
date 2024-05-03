using Microsoft.AspNetCore.Mvc;

namespace Tatook.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
