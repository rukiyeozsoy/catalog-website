using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class CoanteController : Controller
    {
        CoanteManager con = new CoanteManager(new EfCoanteRepository());
        public IActionResult Index()
        {
            var values = con.GetList();
            return View(values);
        }
    }
}
