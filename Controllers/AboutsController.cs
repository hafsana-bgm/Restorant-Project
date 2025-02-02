using Microsoft.AspNetCore.Mvc;

namespace Restorant_Project.Controllers
{
    public class AboutsController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
