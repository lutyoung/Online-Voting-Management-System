using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IPollService _pollService;

        public CandidateController(ICandidateService candidateService, IPollService pollService)
        {
            _candidateService = candidateService;
            _pollService = pollService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.candidates = _candidateService.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            List<Poll> polls = _pollService.GetAll();
            List<SelectListItem> listPolls = new List<SelectListItem>();
            foreach (Poll poll in polls)
            {
                SelectListItem list = new SelectListItem(poll.PollName, poll.Id.ToString());
                listPolls.Add(list);
               
            }
            ViewBag.polls = listPolls;
            return View();
        }

        [HttpPost]
        public IActionResult Register(Candidate candidate)
        {
            ViewBag.candidates = _candidateService.AddCandidate(candidate);
           
            return View();
        }
    }
}
