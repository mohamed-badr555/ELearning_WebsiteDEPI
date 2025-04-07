using DEPI_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Project.DB_Context
{
    internal class E_LearningDB : DbContext
    {
        public E_LearningDB()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER = YOUR_SERVER_NAME; DATABASE = E-Learning Website; INTEGRATED SECURTY = TRUE;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>()
                .HasOne<Exam>()
                .WithOne("Video")
                .HasForeignKey<Video>(a => a.ExamID);

            modelBuilder.Entity<Question>()
                .HasOne<QuestionChoice>()
                .WithOne("Question")
                .HasForeignKey<Question>(a => a.QuestionChoiceID);

            modelBuilder.Entity<CourseAccount>()
                .HasKey(a => new {a.CourseID, a.AccountID});

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(a => a.Fname).IsRequired();
                entity.Property(a => a.Lname).IsRequired();
                entity.Property(a => a.Gender).IsRequired();
                entity.Property(a => a.Country).IsRequired();
                entity.Property(a => a.Phone).IsRequired();
                entity.Property(a => a.Birthdate).IsRequired();
                entity.Property(a => a.Username).IsRequired();
                entity.Property(a => a.Email).IsRequired();
                entity.Property(a => a.EduLevel).IsRequired();
            });

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
                entity.Property(a => a.Type).IsRequired();
                //entity.Property(a => a.Text).IsRequired();
            });

            modelBuilder.Entity<QuestionChoice>(entity =>
            {
                entity.Property(a => a.Text).IsRequired();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(a => a.Name).IsRequired();
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(a => a.Title).IsRequired();
                entity.Property(a => a.URL).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseUnit> CourseUnits { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionChoice> QuestionChoices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoComment> VideoComments { get; set; }
    }
}