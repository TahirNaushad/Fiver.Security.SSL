using Microsoft.AspNetCore.Mvc;

namespace Fiver.Security.SSL.Controllers
{
    //[RequireHttps]
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Movies");
        }
    }
}
