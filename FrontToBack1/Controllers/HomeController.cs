using FrontToBack1.DAL;
using FrontToBack1.Models;
using FrontToBack1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders= _appDbContext.Sliders.ToList();
            homeVM.SliderDetail = _appDbContext.SliderDetails.FirstOrDefault();
           
            return View(homeVM);
        }
    }
}
