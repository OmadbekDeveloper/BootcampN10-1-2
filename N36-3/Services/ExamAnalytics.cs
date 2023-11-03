using N36_3.Services;
using N36_HT3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT3.Services
{
    public class ExamAnalytics
    {
        private readonly UserService _userService;
        private readonly ExamScoreService _examScoreService;

        public ExamAnalytics(UserService userService, ExamScoreService examScoreService)
        {
            _userService = userService;
            _examScoreService = examScoreService;
        }

        public IEnumerable<(string FullName, int Score)> GetScores()
        {
            return _userService.GetAll().Select(user =>
            {
                var fullName = $"{user.FirstName} {user.LastName}";
                var score = _examScoreService.GetById(user.Id).Score;
                return (fullName, score);
            });
        }


    }
}
