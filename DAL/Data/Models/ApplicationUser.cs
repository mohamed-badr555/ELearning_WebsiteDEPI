using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DAL.Data.Models
{

    // Username, Email, and PhoneNumber are already built into IdentityUser — no need to redefine them.
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(25)]
        public string Fname { get; set; }

        [MaxLength(25)]
        public string Lname { get; set; }

<<<<<<< HEAD
        public Gender Gender { get; set; }
=======
        public bool Gender { get; set; }
>>>>>>> origin/register

        [MaxLength(60)]
        public string Country { get; set; }

        public DateTime Birthdate { get; set; }

        [MaxLength(50)]
<<<<<<< HEAD
        public string EduLevel { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }
=======
        public int EduLevel { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }
        public int countryId { get; set; }
>>>>>>> origin/register

        [MaxLength(500)]
        public string? ImageUrl { get; set; }

        // 👇 Computed property for Age
        public int Age => DateTime.Today.Year - Birthdate.Year;

        // 👇 Many-to-Many: Courses
        public ICollection<CourseAccount> CourseAccounts { get; set; }

        // 👇 One-to-Many: Answers
        public ICollection<AccountAnswer> AccountAnswers { get; set; }
<<<<<<< HEAD


=======
        
>>>>>>> origin/register
    }
    public enum Gender
    {
        Male,
        Female
    }
<<<<<<< HEAD


}
=======
}
>>>>>>> origin/register
