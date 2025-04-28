using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
<<<<<<< HEAD
    public class Category :BaseEntity
=======
    public class Category
>>>>>>> origin/register
    {
       
        [MaxLength(100, ErrorMessage ="Category Name Is Required") ]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
