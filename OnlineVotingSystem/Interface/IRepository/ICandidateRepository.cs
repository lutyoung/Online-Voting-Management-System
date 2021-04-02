using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IRepository
{
    public interface ICandidateRepository
    {
        public Candidate AddCandidate(Candidate candidate);

        public List<Candidate> GetAll();

        public Candidate GetCandidateByEmail(string email);

    }
}
