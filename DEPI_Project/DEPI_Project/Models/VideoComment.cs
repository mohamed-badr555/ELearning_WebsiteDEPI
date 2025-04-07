using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.Models
{
    internal class VideoComment
    {
        public int ID { get; set; }
        [MaxLength(3000)]
        public string? Text { get; set; }
        public DateTime Time { get; set; }

        public ICollection<Video> videos { get; set; }
    }
}
