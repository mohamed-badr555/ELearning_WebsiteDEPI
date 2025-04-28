using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Models
{
    public class Comment :BaseEntity
    {
       
        [MaxLength(3000)]
        public string? Text { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Video")]
        public int VideoId { get; set; }
        public Video? Video { get; set; }
        public int UserId { get; set; }

    }
}
