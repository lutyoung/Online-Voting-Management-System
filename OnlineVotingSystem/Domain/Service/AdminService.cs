using OnlineVotingSystem.Interface.IRepository;
using OnlineVotingSystem.Interface.IService;
using OnlineVotingSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Domain.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Admin AddAdmin(Admin admin)
        {
            return _adminRepository.AddAdmin(admin);
        }

        public Admin GetAdmin(int id)
        {
            return _adminRepository.GetAdmin(id);
        }

        public List<Admin> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public Admin Login(string email, string password)
        {
            var admin = _adminRepository.FindByEmail(email);
            if (admin == null || admin.Password != password)
            {
                return null;
            }
            return admin;
        }

        public Admin UpdateAdmin(Admin admin)
        {
            return _adminRepository.UpdateAdmin(admin);
        }

        public Admin GetDetails(int id)
        {
            return _adminRepository.GetDetails(id);
        }

        public void DeleteAdmin(int id)
        {
            _adminRepository.DeleteAdmin(id);
        }

    }
}
