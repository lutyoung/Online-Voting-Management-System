using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Models
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        public override bool IsValid(object dateOfBirth)
        {
            DateTime date;
            if(DateTime.TryParse(dateOfBirth.ToString(), out date))
            {
                return date.AddDays(_minimumAge) < DateTime.Now;
            }
            return false;
        }
    }
}
