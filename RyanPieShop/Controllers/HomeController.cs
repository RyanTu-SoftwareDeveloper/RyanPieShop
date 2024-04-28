using Microsoft.AspNetCore.Mvc;
using RyanPieShop.Models;
using RyanPieShop.ViewModels;

namespace RyanPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
    

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
   
        }
        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
