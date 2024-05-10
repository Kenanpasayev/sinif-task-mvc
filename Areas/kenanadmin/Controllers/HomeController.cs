using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Areas.kenanadmin.Controllers
{
    [Area("kenanadmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
