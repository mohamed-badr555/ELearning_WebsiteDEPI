using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ExamRepo
{
    public interface IExamRepo
    {
        IQueryable<Exam> GetAll();
        Exam GetById(int id);
        void Insert(Exam Exam);
        void Update(Exam Exam);
        void Delete(Exam Exam);
    }
}
