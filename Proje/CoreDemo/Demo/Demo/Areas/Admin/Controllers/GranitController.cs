using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Demo.Areas.Admin.Models;
using Demo.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using X.PagedList;

using System.Web;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Policy = "RequireLoggedIn")]
	public class GranitController : Controller
	{
		GranitManager gra = new GranitManager(new EfGranitRepository());
		public IActionResult Index(int page=1)
		{
			var values = gra.GetList().ToPagedList(page, 5);
			return View(values);
		}

		//[HttpGet]
		//public IActionResult AddGranit()
		//{
		//    return View();
		//}
		//[HttpPost]
		//public IActionResult AddGranit(Granit p)
		//{
		//    GranitValidator grav = new GranitValidator();
		//    ValidationResult result = grav.Validate(p);
		//    if (result.IsValid)
		//    {
		//        p.Granit_Status = true;
		//        gra.TAdd(p);
		//        return RedirectToAction("Index", "Granit");
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

		public IActionResult AddImage(AddGranitImage p)
		{
			Granit graadd = new Granit();
			if (p.Granit_Image != null)
			{
				var extension = Path.GetExtension(p.Granit_Image.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CoreBlogTema/images/granit/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				
				p.Granit_Image.CopyTo(stream);
				graadd.Granit_Image = newimagename;
			}
			graadd.Granit_Name = p.Granit_Name;
			gra.TAdd(graadd);
			
			return RedirectToAction("Index", "Granit");
		}

		public IActionResult DeleteGranit(int id)
		{
			var value = gra.GetById(id);
			gra.TDelete(value);
			return RedirectToAction("Index");
		}
	}
}
