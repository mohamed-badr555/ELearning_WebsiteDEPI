using BLL.DTOs.QuestionChoiceDTOs;
using BLL.DTOs.QuestionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers.QuestionChoiceManager
{
    public interface IQuestionChoiceManager
    {
        IQueryable<QcReadDto> GetAll();
        QcReadDto GetById(int id);
        void Insert(QcAddDto questionChoice);
        void Update(QcUpdateDto questionChoice);
        void Delete(int id);
    }
}
