using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAplication.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
