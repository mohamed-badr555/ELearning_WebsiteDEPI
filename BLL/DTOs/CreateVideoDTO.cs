using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class CreateVideoDTO
    {
        public string? Title { get; set; }
        public IFormFile? File { get; set; }
        public int UploadedByUserId { get; set; }
        public int CourseId { get; set; }

    }
}
