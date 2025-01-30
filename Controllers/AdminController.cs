using Microsoft.AspNetCore.Mvc;

namespace Restorant_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
