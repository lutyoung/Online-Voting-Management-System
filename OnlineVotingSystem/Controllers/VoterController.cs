using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View(_voterService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Voter voter)
        {
            if (ModelState.IsValid)
            {
                _voterService.AddVoter(voter);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
