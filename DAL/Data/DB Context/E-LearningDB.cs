﻿using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB_Context
{
    public class E_LearningDB : IdentityDbContext<ApplicationUser>
    {
        public E_LearningDB(DbContextOptions<E_LearningDB> options) : base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure one-to-one relationship between Exam and Video
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Video)
                .WithOne(v => v.Exam)
                .HasForeignKey<Video>(v => v.ExamID)
                .OnDelete(DeleteBehavior.Restrict); 

            // One-to-many: Question to QuestionChoices
            modelBuilder.Entity<QuestionChoice>()
                .HasOne(qc => qc.Question)
                .WithMany(q => q.QuestionChoices)
                .HasForeignKey(qc => qc.QuestionID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-one: Question to CorrectChoice
            modelBuilder.Entity<Question>()
                .HasOne(q => q.CorrectChoice)
                .WithOne()
                .HasForeignKey<Question>(q => q.CorrectChoiceID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseAccount>()
                .HasKey(a => new {a.CourseID, a.AccountID});

  

            modelBuilder.Entity<Category>()
                .Property(a => a.Name)
                .IsRequired();

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(a => a.Title).IsRequired();
                entity.Property(a => a.Level).IsRequired();
                entity.Property(a => a.Path).IsRequired();
                entity.Property(a => a.Duration).IsRequired();
            });

            modelBuilder.Entity<CourseUnit>(entity =>
            {
                entity.Property(a => a.Title).IsRequired();
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(a => a.Title).IsRequired();
                entity.Property(a => a.TimeInMinutes).IsRequired();
            });

            modelBuilder.Entity<Question>(entity =>
            {
                //entity.Property(a => a.Type).IsRequired();
                entity.Property(a => a.Text).IsRequired();
            });

            modelBuilder.Entity<QuestionChoice>(entity =>
            {
                entity.Property(a => a.Text).IsRequired();
            });

  

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(a => a.Title).IsRequired();
                entity.Property(a => a.URL).IsRequired();
            });


            // Seeding Roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "Instructor", NormalizedName = "INSTRUCTOR" }
            );






            // Seeding Users
            modelBuilder.Entity<ApplicationUser>().HasData(
              new ApplicationUser
              {
                  Id = "admin-user-id",
                  UserName = "admin@example.com",
                  NormalizedUserName = "ADMIN@EXAMPLE.COM",
                  Email = "admin@example.com",
                  NormalizedEmail = "ADMIN@EXAMPLE.COM",
                  Fname = "Admin",
                  Lname = "User",
                  EduLevel = "Master's",
                  Country = "USA",
                  Birthdate = new DateTime(1985, 6, 15),
                  Gender = Gender.Male,
                  PasswordHash = HashPassword(null, "Admin123!") // Manually hashing password
              }
          );


            // Seeding Courses
            modelBuilder.Entity<Course>().HasData(
                    new Course { ID = 1, Title = "Math 101", Description = "Basic mathematics", Duration = TimeSpan.FromHours(50) , Details = "That is a course that cover the fundamentals of mathematics "  , Level= "Beginner" , Path = "pathx"},
                    new Course { ID = 2, Title = "Physics 101", Description = "Basic physics", Duration = TimeSpan.FromHours(150) , Details= "That is a course that cover the fundamentals of Physics " , Level = "Beginner", Path = "pathy" },
                    new Course { ID = 3, Title = "Computer Science 101", Description = "Introduction to Computer Science", Duration = TimeSpan.FromHours(120) , Details = "That is a course that cover the fundamentals of Computer Science " , Level= "Beginner", Path = "pathz" }
            );

            base.OnModelCreating(modelBuilder);

        }



        
        private static string HashPassword(UserManager<ApplicationUser> userManager, string password)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var hashedPassword = hasher.HashPassword(null, password);
            return hashedPassword;
        }
    


    
    public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseUnit> CourseUnits { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionChoice> QuestionChoices { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoComment> VideoComments { get; set; }
        public DbSet<AccountAnswer> AccountAnswers { get; set; }



    }
}