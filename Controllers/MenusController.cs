using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restorant_Project.Data;
using Restorant_Project.Models;
using Restorant_Project.ViewModel;
using static Restorant_Project.ViewModel.Helper;


namespace Restorant_Project.Controllers
{
    public class MenusController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MenusController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult MenuCreate()
        {
            ViewBag.LebelList = _context.Lebels.Select(x => new SelectListItem
            {
                Value = x.LebelId.ToString(),
                Text = x.LebelName

            }).ToList(); 

            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> MenuCreate(MenuVM product)
        {
            string UniqueFileName = null;
            if(product.UploadImage !=null)
            {
                string UploadFolder = Path.Combine(Directory.GetCurrentDirectory(), UploadFolder = Image.UploadFolder);
                UniqueFileName = Guid.NewGuid().ToString() + "_" + product.UploadImage.FileName;
                string filepath = Path.Combine(UploadFolder, UniqueFileName);

                if (!Directory.Exists(UploadFolder))
                {
                    Directory.CreateDirectory(UploadFolder); 
                }

                using (var filestream = new FileStream(filepath,FileMode.Create))
                {
                    await product.UploadImage.CopyToAsync(filestream);
                }

            }


            var RealDataModel = new Menu();

            RealDataModel.Name = product.Name;
            RealDataModel.Price = product.Price;
            RealDataModel.Description = product.Description;
            RealDataModel.Image = UniqueFileName;      


            _context.Menu.Add(RealDataModel);
            _context.SaveChanges();


            ViewBag.LebelList = _context.Lebels.Select(x => new SelectListItem
            {
                Value = x.LebelId.ToString(),
                Text = x.LebelName

            }).ToList();
            return RedirectToAction("MenuCreate");
        }

        public IActionResult MenuList()
        {
            var data = _context.Menu.ToList();
            return View();
        }

        public IActionResult LeblsCreate(Lebel datamodel)
        {
            try
            {
                _context.Lebels.Add(datamodel);
                _context.SaveChanges();
                return Json(true);
            }
            catch (Exception)
            {
                return Json(true);
            }

           
        }

        public IActionResult Lebls()
        {
            var data = _context.Lebels.ToList();

            return View(data);
        }
    }
}
