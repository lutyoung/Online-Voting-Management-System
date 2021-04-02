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

        public void DeleteVoter(int id);

        public Voter GetVoter(int id);

        public Voter GetVoterByCardNumber(string cardNumber);

        public Voter UpdateVoter(Voter voter);

        public Voter Login(string email, string password);


    }
}
