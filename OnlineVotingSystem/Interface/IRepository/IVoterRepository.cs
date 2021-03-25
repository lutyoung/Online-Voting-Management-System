using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IRepository
{
    public interface IVoterRepository
    {
        public Voter AddVoter(Voter voter);

        public Voter FindByEmail(string email);

        public List<Voter> GetAll();
    }
}
