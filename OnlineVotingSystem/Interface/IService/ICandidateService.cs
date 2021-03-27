using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IService
{
    public interface ICandidateService
    {
        public Candidate AddCandidate(Candidate candidate);

        public List<Candidate> GetAll();

    }
}
