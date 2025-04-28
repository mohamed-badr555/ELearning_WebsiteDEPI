using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AccountDTOs
{
    public class RegisterDto
    {
        [MaxLength(30)]
        public string firstName { get; set; }
        [MaxLength(30)]
        public string lastName { get; set; }
        [MaxLength(20)]
        public string phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public int countryId { get; set; }
        [DataType(DataType.Password)]
        public string passowrd { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
        public int eduLevel { get; set; }
        public string Role { get; set; }
    }
}