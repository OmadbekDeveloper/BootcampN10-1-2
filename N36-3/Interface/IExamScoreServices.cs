using N36_HT3.Models;
using N36_3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT3.Interface
{
    public interface IExamScoreService
    {
        ExamScore Create(ExamScore examScore);
        ExamScore GetById(Guid id);
        IEnumerable<ExamScore> GetAll();
        ExamScore Update(ExamScore examScore);
        bool Delete(Guid id);
    }
}
