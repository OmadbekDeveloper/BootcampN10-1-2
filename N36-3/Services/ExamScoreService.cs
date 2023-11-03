using N36_HT3.Interface;
using N36_HT3.Models;
using N36_HT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_3.Services
{
    public class ExamScoreService : IExamScoreService
    {

        private readonly List<ExamScore> examServices;

        public ExamScoreService()
        {
            examServices = new List<ExamScore>();
        }

        public ExamScore Create(ExamScore examScore)
        {
            ExamScore existExamScore = examServices.FirstOrDefault(m => m.Id.Equals(examScore.Id));

            if (existExamScore != null)
            {
                throw new Exception("ExamScore already exists");
            }

            existExamScore.Id = examScore.Id;
            existExamScore.UserId = examScore.UserId;
            existExamScore.Score = examScore.Score;

            examServices.Add(examScore);

            return existExamScore;
        }

        public bool Delete(Guid id)
        {
            var existUser = examServices.FirstOrDefault(u => u.Id == id);

            if (existUser != null)
            {
                examServices.Remove(existUser);
                return true;
            }

            return false;
        }

        public IEnumerable<ExamScore> GetAll()
        {
            return examServices;
        }

        public ExamScore GetById(Guid id)
        {
            ExamScore existExam = examServices.FirstOrDefault(m => m.Id.Equals(id));

            if (existExam is null)
                throw new Exception("Exam is not found");

            return existExam;
        }

        public ExamScore Update(ExamScore examScore)
        {
            ExamScore existExam = examServices.FirstOrDefault(u => u.Id == examScore.Id);

            if (existExam != null)
            {
                existExam.UserId = examScore.UserId;
                existExam.Score = examScore.Score;
            }

            return existExam;
        }
    }

}
