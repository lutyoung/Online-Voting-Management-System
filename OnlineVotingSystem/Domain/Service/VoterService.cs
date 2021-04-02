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

        public void DeleteVoter(int id)
        {
            _voterRepository.DeleteVoter(id);
        }

        public Voter GetVoterByCardNumber(string cardNumber)
        {
           return  _voterRepository.GetVoterByCardNumber(cardNumber);
        }

        public Voter GetVoter(int id)
        {
            return _voterRepository.GetVoter(id);
        }

        public Voter UpdateVoter(Voter voter)
        {
            return _voterRepository.UpdateVoter(voter);
        }

        public Voter Login(string email, string password)
        {
            
            var voter = _voterRepository.FindByEmail(email);
            if (voter == null || voter.Password != password)
            {
                return null;
            }
            return voter;
        }
    }
}
