using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
<<<<<<< HEAD
    public class VideoComment :BaseEntity
=======
    public class VideoComment
>>>>>>> origin/register
    {
       
        [MaxLength(3000)]
        public string? Text { get; set; }
        public DateTime Time { get; set; }

        public int VideoId { get; set; }
        public Video video { get; set; }

    }
}
