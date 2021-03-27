using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Service
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public Candidate AddCandidate(Candidate candidate)
        {
            return _candidateRepository.AddCandidate(candidate);
        }

        public List<Candidate> GetAll()
        {
            return _candidateRepository.GetAll();
        }
    }
}
