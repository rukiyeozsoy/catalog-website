using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abo = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = abo.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
