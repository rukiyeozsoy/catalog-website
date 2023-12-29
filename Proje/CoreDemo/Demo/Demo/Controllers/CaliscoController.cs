using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	[AllowAnonymous] 
	public class CaliscoController : Controller
	{

		CaliscoManager cal = new CaliscoManager(new EfCaliscoRepository());
		public IActionResult Index()
		{
			var values = cal.GetList();
			return View(values);
		}
	}
}
