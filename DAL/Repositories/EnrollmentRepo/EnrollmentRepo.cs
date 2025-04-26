using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CourseAccountRepo
{
    public class EnrollmentRepo : GenericRepository<CourseAccount>
    {
        public EnrollmentRepo(E_LearningDB context) : base(context) { }
    }
}
