using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Demo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        private readonly AdminManager _adminManager;

        public AdminController()
        {
            var context = new Context();

            var adminRepository = new EfAdminRepository(context);
            _adminManager = new AdminManager(adminRepository);
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }

        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                bool isValid = _adminManager.ValidateUser(loginModel.UserName, loginModel.Password);

                if (isValid)
                {
                    HttpContext.Session.SetString("username", loginModel.UserName);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, loginModel.UserName),
                    };
                    var userIdentity = new ClaimsIdentity(claims,"a");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    return RedirectToAction("Index", "Calisco", new { area = "Admin" });
    
                }
                else
                {
                    TempData["Error"] = "Kullanıcı adı veya şifre hatalı!";
                }
            }
            else
            {
                TempData["Error"] = "Girilen veriler geçersiz!";
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}
