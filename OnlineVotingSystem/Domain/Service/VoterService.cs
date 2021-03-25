using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Service
{
    public class VoterService : IVoterService
    {

        private readonly IVoterRepository _voterRepository;

        public VoterService(IVoterRepository voterRepository)
        {
            _voterRepository = voterRepository;
        }

        public Voter AddVoter(Voter voter)
        {
            return _voterRepository.AddVoter(voter);
        }

        public List<Voter> GetAll()
        {
            return _voterRepository.GetAll();
        }
    }
}
