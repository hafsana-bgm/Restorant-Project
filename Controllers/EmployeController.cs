using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Restorant_Project.Data;
using Restorant_Project.Models;

namespace Restorant_Project.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult ChefsCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChefsCreateSubmit([FromBody]Chefs employee)
        {
            if (employee.Name !=null && employee.Designation !=null && employee.Image !=null && employee.Twitter !=null && employee.facebook !=null && employee.Instagram !=null)
            {
              
                return Json(new {success= true, message = "Data Saved!"});
            }

            return Json(new {success=false, Message="Invalid"});
        }



    }
}
