using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAplication.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
