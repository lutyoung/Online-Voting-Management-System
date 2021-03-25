using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IService
{
    public interface IAdminService
    {
        public Admin AddAdmin( Admin admin);

        public Admin Login(string email, string password);

        public List<Admin> GetAll();

        public Admin GetAdmin(int id);

        public Admin UpdateAdmin(Admin admin);

        public Admin GetDetails(int id);

        public void DeleteAdmin(int id);
    }
}
