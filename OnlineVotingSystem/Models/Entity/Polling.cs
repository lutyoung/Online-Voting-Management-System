using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Polling : BaseEntity
    {
     
        public string PollingName { get; set; }

        public DateTime PollingDate { get; set; }

        public string PollingDescription { get; set; }

        public IList<Vote> Votes = new List<Vote>();

        public IList<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
