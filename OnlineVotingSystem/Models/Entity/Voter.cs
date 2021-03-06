using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models.Entity
{
    public class Voter : BaseEntity
    {
        //[Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

       
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [DisplayName("FirstName")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [DisplayName("LastName")]
        [StringLength(160)]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "MiddleName is required")]
        //[DisplayName("MiddleName")]
        //[StringLength(160)]
        public string MiddleName { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
           ErrorMessage = "Email is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinimumAge(18)]
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }

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
