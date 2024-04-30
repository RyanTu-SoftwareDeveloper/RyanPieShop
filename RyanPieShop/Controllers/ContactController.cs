using Microsoft.AspNetCore.Mvc;

namespace RyanPieShop.Controllers
{
    public class ContactController : Controller
    {
        public  IActionResult Index()
        {
            return View();  
        }
    }
}
