using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeExercise.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        
        [PersonalData]  
        public string LastName { get; set; }

        [PersonalData]
        public Gender Gender { get; set;}

        [PersonalData]
        public string IDCard { get; set; }

        [PersonalData]
        public DateTime BirthDate { get; set; }

        [PersonalData]
        public Department Department { get; set; }

        [PersonalData]
        public string Position { get; set; }

        [PersonalData]
        public string Supervisor { get; set; }
    }

    public enum Gender
    {
		Male = 1,
		Female = 2,
        Other = 3
    }
}
