using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Service
{
    public class PollService : IPollService
    {
        private readonly IPollRepository _pollRepository;

        public PollService(IPollRepository pollRepositroy)
        {
            _pollRepository = pollRepositroy;
        }
        public Poll AddPoll(Poll poll)
        {
            return _pollRepository.AddPoll(poll);
        }

        public void DeletePoll(int id)
        {
            _pollRepository.DeletePoll(id);
        }

        public List<Poll> GetAll()
        {
            return _pollRepository.GetAll();
        }

        public Poll GetPoll(int id)
        {
            return _pollRepository.GetPoll(id);
        }
    }
}
