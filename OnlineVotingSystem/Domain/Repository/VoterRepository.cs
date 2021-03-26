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

        public void DeleteVoter(int id)
        {
            var voter = _votingContext.Voters.Find(id);
            if (voter != null)
            {
                _votingContext.Voters.Remove(voter);
                _votingContext.SaveChanges();
            }
        }

        public Voter GetVoter(int id)
        {
            var voter = _votingContext.Voters.Where(v => v.Id == id).FirstOrDefault();
            return voter;
        }

        public Voter GetDetails(int id)
        {
            var voter = _votingContext.Voters
               .Where(v => v.Id == id).FirstOrDefault();
            return voter;
        }

        public Voter UpdateVoter(Voter voter)
        {
            _votingContext.Voters.Update(voter);
            _votingContext.SaveChanges();
            return voter;
        }
    }
}
