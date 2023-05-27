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
    public class BelencoController : Controller
    {
        BelencoManager bel = new BelencoManager(new EfBelencoRepository());
        public IActionResult Index(int page=1)
        {
            var values = bel.GetList().ToPagedList(page, 5);
            return View(values);
        }
        
        //[HttpGet]
        //public IActionResult AddBelenco()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddBelenco(Belenco p)
        //{
        //    BelencoValidator belv=new BelencoValidator();
        //    ValidationResult result=belv.Validate(p);
        //    if (result.IsValid)
        //    {
        //        p.Belenco_Status = true;
        //        bel.TAdd(p);
        //        return RedirectToAction("Index", "Belenco");
        //    }
        //    else
        //    {
        //        foreach(var item in result.Errors)
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
        public IActionResult AddImage(AddBelencoImage p)
        {
            Belenco beladd = new Belenco(); ;
            if (p.Belenco_Image != null)
            {
                var extension = Path.GetExtension(p.Belenco_Image.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoreBlogTema/images/belenco/",newimagename);
                var stream=new FileStream(location, FileMode.Create);
                p.Belenco_Image.CopyTo(stream);
                beladd.Belenco_Image = newimagename;
            }
            beladd.Belenco_Name=p.Belenco_Name;
            bel.TAdd(beladd);
            return RedirectToAction("Index", "Belenco");
        }
        
        public IActionResult DeleteBelenco(int id)
        {
            var value = bel.GetById(id);
            bel.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
