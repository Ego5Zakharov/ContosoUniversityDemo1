using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversityDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
