using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class Video_DTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string ?FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public List<CommentDTO>? Comments { get; set; }
        public string? Description { get; set; }
        [MaxLength(1500)]
        public string? URL { get; set; }
        public int order { get; set; }
    }
}
