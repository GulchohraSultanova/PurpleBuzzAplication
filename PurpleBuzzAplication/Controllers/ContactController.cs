using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAplication.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
