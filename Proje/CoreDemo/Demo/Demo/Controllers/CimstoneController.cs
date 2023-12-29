using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	[AllowAnonymous]
	public class CimstoneController : Controller
	{
		CimstoneManager cim = new CimstoneManager(new EfCimstoneRepository());
		public IActionResult Index()
		{
			var values = cim.GetList();
			return View(values);
		}
	}
}
