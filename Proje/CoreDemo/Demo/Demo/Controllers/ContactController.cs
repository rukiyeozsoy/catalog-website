using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Demo.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManager conm = new ContactManager(new EfContactRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.Contact_Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.Contact_Status = true;
			conm.ContactAdd(p);
			return View();
		}
	}
}
