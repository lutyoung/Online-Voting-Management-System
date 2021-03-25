using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Vote : BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public DateTime VoteDate { get; set; }

        public enum VoteType
        {
            National,
            State,
            Local
        }

        public VoteType Name { get;set; }

        public string VoteDiscription { get; set; }

    }
}
