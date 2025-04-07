using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Account
    {
        public int ID { get; set; }
        [MaxLength(25)]
        public string Fname { get; set; }
        [MaxLength(25)]
        public string Lname { get; set; }
        [MaxLength(20)]
        public string Gender { get; set; }
        [MaxLength(30)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }//Note
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string EduLevel { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }
        [MaxLength(1000)]
        public string? ImageUrl { get; set; }

        #region Course - Account (M-M)
        public ICollection<CourseAccount> CourseAccounts { get; set; }
        #endregion

        #region Account - Role (1 - M)
        public int RoleID { get; set; }//Foreign key
        public Role Role { get; set; } 
        #endregion
    }
}
