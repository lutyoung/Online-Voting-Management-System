using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IService
{
    public interface IPollService
    {
        public Poll AddPoll(Poll poll);

        public List<Poll> GetAll();

        public void DeletePoll(int id);

        public Poll GetPoll(int id);
    }
}
