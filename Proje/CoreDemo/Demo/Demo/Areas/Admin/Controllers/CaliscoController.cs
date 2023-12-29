using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Demo.Areas.Admin.Models;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using X.PagedList;

namespace Demo.Areas.Admin.Controllers
{
	[Authorize(Policy = "RequireLoggedIn")]
	[Area("Admin")]
	public class CaliscoController : Controller
	{
		CaliscoManager cal = new CaliscoManager(new EfCaliscoRepository());
		public IActionResult Index(int page = 1)
		{
			var values = cal.GetList().ToPagedList(page, 5);
			return View(values);
		}

		//[HttpGet]
		//public IActionResult AddCalisco()
		//{
		//    return View();
		//}

		//[HttpPost]
		//public IActionResult AddCalisco(Calisco p)
		//{
		//    CaliscoValidator calv = new CaliscoValidator();
		//    ValidationResult result = calv.Validate(p);
		//    if (result.IsValid)
		//    {
		//        p.Calisco_Status = true;
		//        cal.TAdd(p);
		//        return RedirectToAction("Index", "Calisco");
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
		public IActionResult AddImage(AddCaliscoImage p)
		{
			Calisco caladd = new Calisco(); ;
			if (p.Calisco_Image != null)
			{
				var extension = Path.GetExtension(p.Calisco_Image.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoreBlogTema/images/calisco/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.Calisco_Image.CopyTo(stream);
				caladd.Calisco_Image = newimagename;
			}
			caladd.Calisco_Name = p.Calisco_Name;
			cal.TAdd(caladd);
			return RedirectToAction("Index", "Calisco");
		}

		public IActionResult DeleteCalisco(int id)
		{
			var value = cal.GetById(id);
			cal.TDelete(value);
			return RedirectToAction("Index");
		}
	}

}
