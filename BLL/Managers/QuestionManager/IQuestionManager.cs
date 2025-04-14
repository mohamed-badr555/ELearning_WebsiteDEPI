using BLL.DTOs.ExamDTOs;
using BLL.DTOs.QuestionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.QuestionManager
{
    public interface IQuestionManager
    {
        IEnumerable<QuestionReadDto> GetAll();
        QuestionReadDto GetById(int id);
        void Insert(QuestionAddDto question);
        void Update(QuestionUpdateDto question);
        void Delete(int id);
    }
}
