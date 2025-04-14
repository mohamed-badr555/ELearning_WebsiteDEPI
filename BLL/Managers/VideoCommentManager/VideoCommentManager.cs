using BLL.DTOs.VideoCommentDTOs;
using BLL.DTOs.VideoDTOs;
using DAL.Data.Models;
using DAL.Repositories.VideoCommentRepo;
using DAL.Repositories.VideoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.VideoCommentManager
{
    public class VideoCommentManager : IVideoCommentManager
    {
        private readonly IVideoCommentRepo _videoCommentRepo;

        public VideoCommentManager(IVideoCommentRepo videoCommentRepo)
        {
            _videoCommentRepo = videoCommentRepo;
        }
        public void Delete(int id)
        {
            var VideoCommentDto = _videoCommentRepo.GetById(id);
            _videoCommentRepo.Delete(VideoCommentDto);
        }

        public IEnumerable<VcReadDto> GetAll()
        {
            var VideoCommentDto = _videoCommentRepo.GetAll().Select(a => new VcReadDto  //*
            {
                //Choose data
            });
            return VideoCommentDto;
        }

        public VcReadDto GetById(int id)
        {
            var VideoCommentModel = _videoCommentRepo.GetById(id);

            var VideoCommentDto = new VcReadDto
            {
                //Choose data
            };
            return VideoCommentDto;
        }

        public void Insert(VcAddDto videoComment)
        {
            var VideoCommentDto = new VideoComment
            {
                //Add data
            };

            _videoCommentRepo.Insert(VideoCommentDto);
        }

        public void Update(VcUpdateDto videoComment)
        {
            var VideoCommentDto = new VideoComment
            {
                //Update data
            };

            //Another Way?

            //var VideoCommentModel = _videoRepo.GetById(VideoComment.id);

            /*
             Data
             */

            _videoCommentRepo.Update(VideoCommentDto);
        }
    }
}
