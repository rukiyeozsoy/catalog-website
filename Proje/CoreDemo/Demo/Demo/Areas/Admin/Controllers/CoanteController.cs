using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Demo.Areas.Admin.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using X.PagedList;

namespace Demo.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Policy = "RequireLoggedIn")]
	public class CoanteController : Controller
	{
		CoanteManager con = new CoanteManager(new EfCoanteRepository());
		public IActionResult Index(int page=1)
		{
			var values = con.GetList().ToPagedList(page, 5);
			return View(values);
		}

		//[HttpGet]
		//public IActionResult AddCoante()
		//{
		//    return View();
		//}
		//[HttpPost]
		//public IActionResult AddCoante(Coante p)
		//{
		//    CoanteValidator conv = new CoanteValidator();
		//    ValidationResult result = conv.Validate(p);
		//    if (result.IsValid)
		//    {
		//        p.Coante_Status = true;
		//        con.TAdd(p);
		//        return RedirectToAction("Index", "Coante");
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
		public IActionResult AddImage(AddCoanteImage p)
		{
			Coante conadd = new Coante(); ;
			if (p.Coante_Image != null)
			{
				var extension = Path.GetExtension(p.Coante_Image.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\CoreBlogTema\images\coante\", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.Coante_Image.CopyTo(stream);
				conadd.Coante_Image = newimagename;
			}
			conadd.Coante_Name = p.Coante_Name;
			conadd.Coante_Status = true;
			con.TAdd(conadd);
			return RedirectToAction("Index", "Coante");
		}

		public IActionResult DeleteCoante(int id)
		{
			var value = con.GetById(id);
			con.TDelete(value);
			return RedirectToAction("Index");
		}
	}
}
