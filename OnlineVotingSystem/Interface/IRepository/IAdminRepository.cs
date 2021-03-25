using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Interface.IRepository
{
    public interface IAdminRepository
    {
        public Admin AddAdmin(Admin admin);

        public Admin FindByEmail(string email);

        public List<Admin> GetAll();

        public Admin GetAdmin(int id);

        public Admin UpdateAdmin(Admin admin);

        public Admin GetDetails(int id);

        public void DeleteAdmin(int id);
    }
}
