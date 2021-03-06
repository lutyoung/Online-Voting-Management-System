using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using OnlineVotingSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class VoterController : Controller
    {
        private readonly IVoterService _voterService;

        public VoterController( IVoterService voterService)
        {
            _voterService = voterService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.voters = _voterService.GetAll();
            return View();
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register( Voter voter)
        {
            ViewBag.voters = _voterService.AddVoter(voter);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voter = _voterService.GetVoter(id.Value);
            if (voter == null)
            {
                return NotFound();
            }
            return View(voter);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            ViewBag.voters.DeleteVoter(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult GetVoterByCardNumber(string cardNumber)
        {
            return View(_voterService.GetVoterByCardNumber(cardNumber));
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var voter = _voterService.GetVoter(id.Value);
            if (voter == null)
            {
                return NotFound();
            }

            return View(voter);
        }

        [HttpPost]
        public IActionResult Update(int id, Voter voter)
        {
            if (id != voter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _voterService.UpdateVoter(voter);
                return RedirectToAction(nameof(Index));
            }
            return View(voter);
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
            try
            {
                var voter = _voterService.Login(email, password);
                if (voter == null)
                {
                    ViewBag.Message = "Invalid email/Password";
                    return RedirectToAction("Login", "Voter");
                }
                else
                {
                    var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, $"{voter.FirstName}"),
                    new Claim(ClaimTypes.GivenName, $"{voter.FirstName} {voter.LastName}"),
                    new Claim(ClaimTypes.NameIdentifier, voter.CardNumber.ToString()),
                    new Claim(ClaimTypes.Email, voter.Email),
                    new Claim(ClaimTypes.Role, "Voter"),
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authenticationProperties = new AuthenticationProperties();
                    var principal = new ClaimsPrincipal(claimsIdentity);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                    return RedirectToAction(nameof(DashBoard));
                }
            }
            catch(Exception e)
            {
                return View(e);
            }
            
        }

        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
