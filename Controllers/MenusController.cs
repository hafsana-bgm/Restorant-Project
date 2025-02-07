﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Restorant_Project.Data;
using Restorant_Project.Models;
using Restorant_Project.ViewModel;

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
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> MenuCreate(MenuVM product)
        {
            string UniqueFileName = null;
            if(product.UploadImage !=null)
            {
                string UploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Upload");
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
