using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly VotingContext _votingContext;
        public CandidateRepository(VotingContext votingContext)
        {
            _votingContext = votingContext;
        }

        public Candidate AddCandidate(Candidate candidate)
        {
            _votingContext.Candidates.Add(candidate);
            _votingContext.SaveChanges();
            return candidate;
        }

        public List<Candidate> GetAll()
        {
            return _votingContext.Candidates.ToList();
        }

        public Candidate GetCandidateByEmail(string email)
        {
            return _votingContext.Candidates.SingleOrDefault(c => c.Email == email);
        }
    }
}
