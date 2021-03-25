using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Result :BaseEntity
    {
        public Candidate Candidate { get; set; }

        public int CandidateId { get; set; }

        public DateTime ResultDate { get; set; }

        public string  ResultType { get; set; }

        public  string ResultDescirption { get; set; } 
    }
}
