using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Repository
{
    public class PollRepository : IPollRepository
    {
        private readonly VotingContext _votingContext;

        public PollRepository(VotingContext votingContext)
        {
            _votingContext = votingContext;
        }

        public Poll AddPoll(Poll poll)
        {
            _votingContext.Polls.Add(poll);
            _votingContext.SaveChanges();
            return poll;
        }

        public void DeletePoll(int id)
        {
            var poll = _votingContext.Polls.Find(id);
            if (poll != null)
            {
                _votingContext.Polls.Remove(poll);
                _votingContext.SaveChanges();
            }
        }

        public List<Poll> GetAll()
        {
            return _votingContext.Polls.ToList();
        }

        public Poll GetPoll(int id)
        {
            var poll = _votingContext.Polls.FirstOrDefault(v => v.Id == id);
              /*  Where(v => v.Id == id).FirstOrDefault();*/
            return poll;
        }
    }
}
