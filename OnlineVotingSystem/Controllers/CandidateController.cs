using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_candidateService.GetAll());
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _candidateService.AddCandidate(candidate);
            }
            return View(candidate);
        }
    }
}
