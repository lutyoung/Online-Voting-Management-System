using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        public IActionResult Index()
        {
            ViewBag.polls = _pollService.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Poll poll)
        {
            ViewBag.polls = _pollService.AddPoll(poll);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = _pollService.GetPoll(id.Value);
            if (poll == null)
            {
                return NotFound();
            }
            return View(poll);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            ViewBag.polls.DeletePoll(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
