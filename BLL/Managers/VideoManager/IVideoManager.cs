using BLL.DTOs.QuestionDTOs;
using BLL.DTOs.VideoDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.VideoManager
{
    public interface IVideoManager
    {
        IQueryable<VideoReadDto> GetAll();
        VideoReadDto GetById(int id);
        void Insert(VideoAddDto video);
        void Update(VideoUpdateDto video);
        void Delete(int id);
    }
}
