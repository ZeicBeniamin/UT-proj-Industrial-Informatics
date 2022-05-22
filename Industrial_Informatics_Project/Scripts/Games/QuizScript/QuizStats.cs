using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.QuizScript
{
    class QuizStats : GameStats
    {
        // Number of corect answers
        public int correct_answers;

        // Number of incorect answers
        public int incorrect_answers;

        public int user_id;

        // Time remaining
        public int minutes;
        public int seconds;
    }
}
