using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Admin : BaseEntity
    {

        [Required(ErrorMessage = "Firstname is required")]
        [DisplayName("Firstname")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        [DisplayName("Lastname")]
        [StringLength(160)]
        public string LastName { get; set; }

        
        public string MiddleName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
           ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(72)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}
