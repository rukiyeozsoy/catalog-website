using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Demo.Areas.Admin.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using X.PagedList;

namespace Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CimstoneController : Controller
    {
        CimstoneManager cim = new CimstoneManager(new EfCimstoneRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cim.GetList().ToPagedList(page, 5);
            return View(values);
        }

        //[HttpGet]
        //public IActionResult AddCimstone()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddCimstone(Cimstone p)
        //{
        //    CimstoneValidator cimv = new CimstoneValidator();
        //    ValidationResult result = cimv.Validate(p);
        //    if (result.IsValid)
        //    {
        //        p.Cimstone_Status = true;
        //        cim.TAdd(p);
        //        return RedirectToAction("Index", "Cimstone");
        //    }
        //    else
        //    {
        //        foreach (var item in result.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(AddCimstoneImage p)
        {
            Cimstone beladd = new Cimstone(); ;
            if (p.Cimstone_Image != null)
            {
                var extension = Path.GetExtension(p.Cimstone_Image.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoreBlogTema/images/cimstone/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Cimstone_Image.CopyTo(stream);
                beladd.Cimstone_Image = newimagename;
            }
            beladd.Cimstone_Name = p.Cimstone_Name;
            cim.TAdd(beladd);
            return RedirectToAction("Index", "Cimstone");
        }

        public IActionResult DeleteCimstone(int id)
        {
            var value = cim.GetById(id);
            cim.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
