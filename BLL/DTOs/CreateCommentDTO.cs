using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class CreateCommentDTO
    {
        public int VideoId { get; set; }
        public int UserId { get; set; }
        public string? Content { get; set; }
    }

}
