using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.SSL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }
    }
}
