using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly VotingContext _votingContext;
        public AdminRepository(VotingContext votingContext)
        {
            _votingContext = votingContext;
        }

        public Admin AddAdmin(Admin admin)
        {
            _votingContext.Admins.Add(admin);
            _votingContext.SaveChanges();
            return admin;
        }

        public Admin FindByEmail(string email)
        {
            return _votingContext.Admins.FirstOrDefault(a => a.Email == email);
        }

        public List<Admin> GetAll()
        {
            return _votingContext.Admins.ToList();
        }

        public Admin GetAdmin(int id)
        {
            var admin = _votingContext.Admins
                .Where(m => m.Id == id).FirstOrDefault();
            return admin;
        }

        public Admin UpdateAdmin(Admin admin)
        {
            _votingContext.Admins.Update(admin);
            _votingContext.SaveChanges();
            return admin;

        }

        public Admin GetDetails(int id)
        {
            var admin = _votingContext.Admins
                .Where(ad => ad.Id == id).FirstOrDefault();
            return admin;

        }

        public void DeleteAdmin(int id)
        {
            var admin = _votingContext.Admins.Find(id);
            if (admin != null)
            {
                _votingContext.Admins.Remove(admin);
                _votingContext.SaveChanges();
            }
        }

    }
}
