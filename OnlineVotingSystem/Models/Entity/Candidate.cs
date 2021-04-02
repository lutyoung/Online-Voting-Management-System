using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Candidate : BaseEntity
    {

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("FirstName")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("LastName")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Middle Name is required")]
        [DisplayName("MiddleName")]
        [StringLength(160)]
        public string MiddleName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [StringLength(160)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
           ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }


        public int PollId { get; set; }

        public Poll Poll { get; set; }
    }
}
