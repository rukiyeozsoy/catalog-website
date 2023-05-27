using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class GranitController : Controller
    {
        GranitManager gra = new GranitManager(new EfGranitRepository());
        public IActionResult Index()
        {
            var values = gra.GetList();
            return View(values);
        }
    }
}
