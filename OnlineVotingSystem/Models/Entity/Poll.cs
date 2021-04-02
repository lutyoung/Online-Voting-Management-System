using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Poll : BaseEntity
    {
     
        public string PollName { get; set; }

        public DateTime PollDate { get; set; }

        public string PollDescription { get; set; }

        public IList<Vote> Votes { get; set;} = new List<Vote>();

        public IList<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
