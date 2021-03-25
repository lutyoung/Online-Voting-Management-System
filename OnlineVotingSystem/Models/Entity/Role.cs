using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }

        public IList<UserRole> UserRoles = new List<UserRole>();
    }
}
