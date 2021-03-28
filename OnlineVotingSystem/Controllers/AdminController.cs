using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_adminService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _adminService.AddAdmin(admin);
            }
            return RedirectToAction("Login");
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string email, string password)
        {

            var admin = _adminService.Login(email, password);
            if (admin == null)
            {
                ViewBag.Message = "Invalid email/Password";
                return RedirectToAction("Login", "AccountHolder");
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, $"{admin.FirstName}"),
                    new Claim(ClaimTypes.GivenName, $"{admin.FirstName} {admin.LastName}"),
                    new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                    new Claim(ClaimTypes.Email, admin.Email),
                    new Claim(ClaimTypes.Role, "Admin"),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                return RedirectToAction(nameof(DashBoard));
            }
        }

        public IActionResult DashBoard()
        {
            return View();
        }




        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = _adminService.GetAdmin(id.Value);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        [HttpPost]
        public IActionResult Edit(int id, Admin admin)
        {
            if (id != admin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _adminService.UpdateAdmin(admin);
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        [HttpGet]
        public IActionResult Details()
        {

            return View(_adminService.GetDetails(int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value)));
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = _adminService.GetAdmin(id.Value);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _adminService.DeleteAdmin(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
