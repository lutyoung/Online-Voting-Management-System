using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Repository
{
    public class VoterRepository : IVoterRepository
    {
        private readonly VotingContext _votingContext;
        public VoterRepository(VotingContext votingContext)
        {
            _votingContext = votingContext;
        }

        public Voter AddVoter(Voter voter)
        {
            _votingContext.Voters.Add(voter);
            _votingContext.SaveChanges();
            return voter;
        }

        public Voter FindByEmail(string email)
        {
            return _votingContext.Voters.FirstOrDefault(a => a.Email == email);
        }

        public List<Voter> GetAll()
        {
            return _votingContext.Voters.ToList();
        }
    }
}
