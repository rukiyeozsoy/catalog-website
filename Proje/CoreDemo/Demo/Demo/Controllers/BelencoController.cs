using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class BelencoController : Controller
    {
        BelencoManager bel = new BelencoManager(new EfBelencoRepository());
        public IActionResult Index()
        {
            var values = bel.GetList();
            return View(values);
        }
    }
}
