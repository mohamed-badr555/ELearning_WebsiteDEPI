using AutoMapper;
using BLL.DTOs;
using DAL.Data.Models;
using DAL.Repositories;
using DAL.Repositories.CourseRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.CourseManager
{
    public class CourseManager : ICourseManager
    {
        private readonly IGenericRepository<Course> _courseRepo;
        private readonly IMapper mapper;

        public CourseManager(IGenericRepository<Course> courseRepo, IMapper mapper)
        {
            _courseRepo = courseRepo;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<CourseListDTO>> GetAllAsync()
        {
            var courses = await _courseRepo.GetAllAsync();
            var courseDtos = mapper.Map<IEnumerable<CourseListDTO>>(courses); // Auto-map

            return courseDtos;
        }
        public async Task<PagedResult<CourseListDTO>> GetPagedCoursesAsync(int page, int pageSize)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0) pageSize = 10;

            var courses = await _courseRepo.GetAllAsync(); // Retrieve all courses
            var totalCount = courses.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            // Apply pagination
            var pagedCourses = courses.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var coursesDTO = mapper.Map<List<CourseListDTO>>(pagedCourses);

            // Return paged result
            return new PagedResult<CourseListDTO>
            {
                Items = coursesDTO,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize
            };
        }

        public async Task<CourseDetailsDTO> GetByIdAsync(int id)
        {
            var CourseModel = await _courseRepo.GetByIdAsync(id);
            if (CourseModel == null)
                throw new KeyNotFoundException($"Course with ID {id} not found.");

            var CourseDto = mapper.Map<CourseDetailsDTO>(CourseModel);
            return CourseDto;
        }

        public async Task AddAsync(CourseAddDTO course_dto)
        {
            
            var course = mapper.Map<Course>(course_dto);
            await _courseRepo.InsertAsync(course);
        }

        public async Task<List<CourseListDTO>> SearchCoursesAsync(string searchTerm)
        {
            var courses = await _courseRepo.GetAllAsync();
            var courses_dtos = mapper.Map<List<CourseListDTO>>(courses);
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                courses_dtos = courses_dtos
                    .Where(c => c.Title.ToLower().Contains(searchTerm) ||
                                c.Description.ToLower().Contains(searchTerm))
                    .ToList();
            }

            return courses_dtos;
        }


        public async Task<List<CourseListDTO>> FilterCoursesAsync(string level, string category)
        {
            var courses = await _courseRepo.GetAllAsync();
            var courseDTOs = mapper.Map<List<CourseListDTO>>(courses);

            if (!string.IsNullOrWhiteSpace(level))
                level = level.ToLower();
            if (!string.IsNullOrWhiteSpace(category))
                category = category.ToLower();

            courseDTOs = courseDTOs.Where(c =>
                (string.IsNullOrWhiteSpace(level) || c.Level.ToLower().Contains(level)) &&
                (string.IsNullOrWhiteSpace(category) || c.CategoryName.ToLower().Contains(category))
            ).ToList();

            return courseDTOs;
        }



        public async Task UpdateAsync(CourseAddDTO CourseDTO)
        {

   
            var course = await _courseRepo.GetByIdAsync(CourseDTO.Id);
      
            if (course == null)
                throw new Exception("Course not found");

            mapper.Map(CourseDTO, course); // maps *into* the existing object


            await _courseRepo.UpdateAsync(course);
        }


        public async Task DeleteAsync(int id)
        {
            var course = await _courseRepo.GetByIdAsync(id);
            if (course == null)
                throw new KeyNotFoundException($"Course with ID {id} not found.");

            await _courseRepo.DeleteAsync(course);
        }

       
    }

        public class PagedResult<T>
        {
            public List<T> Items { get; set; }
            public int TotalCount { get; set; }
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
            public int PageSize { get; set; }
        }
    }
