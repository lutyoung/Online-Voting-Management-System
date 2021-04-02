using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Vote : BaseEntity
    {
        public int VoterId { get; set; }

        public Voter Voter { get; set; }

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public int PollId { get; set; }

        public Poll Poll { get; set; }
    }
}
