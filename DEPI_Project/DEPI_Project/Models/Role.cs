using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class Role
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
