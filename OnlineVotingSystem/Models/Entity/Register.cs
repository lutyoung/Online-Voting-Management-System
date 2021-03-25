using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Register : BaseEntity
    {
        public User User { get; set; }

        public Candidate Candidate { get; set; }

        public int UserId { get; set; }

        public int CandidateId { get; set; }

        public string RegisterName { get; set; }

        public string RegisterType { get; set; }

        public string RegisterDescription { get; set; }

    }
}
