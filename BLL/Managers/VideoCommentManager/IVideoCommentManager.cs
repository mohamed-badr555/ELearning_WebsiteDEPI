using BLL.DTOs.VideoCommentDTOs;
using BLL.DTOs.VideoDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.VideoCommentManager
{
    public interface IVideoCommentManager
    {
        IEnumerable<VcReadDto> GetAll();
        VcReadDto GetById(int id);
        void Insert(VcAddDto video);
        void Update(VcUpdateDto video);
        void Delete(int id);
    }
}
