using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IService
{
    public interface IVoterService
    {
        public Voter AddVoter(Voter voter);

        public List<Voter> GetAll();

    }
}
