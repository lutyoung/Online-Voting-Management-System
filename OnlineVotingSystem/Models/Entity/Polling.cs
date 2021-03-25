using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Polling : BaseEntity
    {
        public string PollingName { get; set; }

        public string PollingType { get; set; }

        public string pollingDescription { get; set; }
    }
}
