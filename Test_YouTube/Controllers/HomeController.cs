using Microsoft.AspNetCore.Mvc;

namespace Test_YouTube.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Shared/Index.cshtml");
        }

        public IActionResult AboutUs_click()
        {
            {
                return View("~/Views/Shared/AboutUsParticle.cshtml");
            
            }
        }
       
    }
}
