using Microsoft.AspNetCore.Mvc;
using PurpleBuzzAplication.DAL;
using PurpleBuzzAplication.Models;
using PurpleBuzzAplication.ViewModels;

namespace PurpleBuzzAplication.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()

        {
            List<Services> services = _dbContext.Services.ToList();
            HomeVM homeVM = new HomeVM();
            homeVM.Services = services;
            return View(homeVM);
        }
    }
}
