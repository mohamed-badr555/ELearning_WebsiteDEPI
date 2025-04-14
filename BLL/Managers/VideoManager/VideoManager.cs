using BLL.DTOs.QuestionDTOs;
using BLL.DTOs.VideoDTOs;
using DAL.Data.Models;
using DAL.Repositories.QuestionRepo;
using DAL.Repositories.VideoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.VideoManager
{
    internal class VideoManager : IVideoManager
    {
        private readonly IVideoRepo _videoRepo;

        public VideoManager(IVideoRepo videoRepo)
        {
            _videoRepo = videoRepo;
        }
        public void Delete(int id)
        {
            var VideoDto = _videoRepo.GetById(id);
            _videoRepo.Delete(VideoDto);
        }

        public IEnumerable<VideoReadDto> GetAll()
        {
            var VideoDto = _videoRepo.GetAll().Select(a => new VideoReadDto  //*
            {
                //Choose data
            });
            return VideoDto;
        }

        public VideoReadDto GetById(int id)
        {
            var VideoModel = _videoRepo.GetById(id);

            var VideoDto = new VideoReadDto
            {
                //Choose data
            };
            return VideoDto;
        }

        public void Insert(VideoAddDto video)
        {
            var VideoDto = new Video
            {
                //Add data
            };

            _videoRepo.Insert(VideoDto);
        }

        public void Update(VideoUpdateDto video)
        {
            var VideoDto = new Video
            {
                //Update data
            };

            //Another Way?

            //var VideoModel = _videoRepo.GetById(Video.id);

            /*
             Data
             */

            _videoRepo.Update(VideoDto);
        }
    }
}