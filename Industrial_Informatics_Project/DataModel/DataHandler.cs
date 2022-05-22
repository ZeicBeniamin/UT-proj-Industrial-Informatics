using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.DataModel
{
    class DataHandler
    {
        public static bool insertUser(string username, string email, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<User> users = (from usr in entities.Users
                                                  select usr)
                .OrderBy(usr => usr.user_id)
                .ToList();
                int last_id = users.Count;
        
                var user = new User
                    {
                        user_id = last_id,
                        user_name = username,
                        email = email,
                        password = password
                    };

                if (entities.Users.Add(user) != null)
                {
                    entities.SaveChanges();
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public static bool isAdmin(string user_name,string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.user_name == user_name && u.password == password);

                if (user != null)
                {
                    if (user.isAdmin == 1)
                        return true;
                }
            }
            return false;
        }

        public static bool isUser(string user_name, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.user_name == user_name && u.password == password);

                if (user != null)
                        return true;              
            }
            return false;
        }

        public static bool existsUser(string email)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => u.email == email);

                if (user != null)
                    return true;
            }
            return false;
        }

        public static int getUserId(string user_name, string password)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var user = entities.Users.SingleOrDefault(u => (u.user_name == user_name && u.password == password));

                if (user != null)
                {
                    return user.user_id;
                }
            }
            return -1;
        }

        public static bool insertStroopStats(Scripts.Games.StroopTestScript.StroopStats stroopStats)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<Stroop_Stats> stats = (from stat in entities.Stroop_Stats
                                     select stat)
                .ToList();
                int last_id = stats.Count;

                var new_stat = new Stroop_Stats

                {
                    id = last_id,
                    user_id = stroopStats.user_id,
                    total_time = stroopStats.totalTime,
                    clicked_under_bar = stroopStats.clickedUnderBar,
                    score = stroopStats.score,
                    date = stroopStats.date,
                    difficulty = stroopStats.difficulty 
                    
                };

                if (entities.Stroop_Stats.Add(new_stat) != null)
                {
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool insertChimpanzeeStats(Scripts.Games.ChimpanzeeTestScript.ChimpanzeeStats chimpanzeeStats)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<Chimpanzee_Stats> stats = (from stat in entities.Chimpanzee_Stats
                                             select stat)
                .ToList();
                int last_id = stats.Count;

                var new_stat = new Chimpanzee_Stats

                {
                    id = last_id,
                    user_id = chimpanzeeStats.user_id,
                    game_time = chimpanzeeStats.game_time,
                    avg_memory_time = chimpanzeeStats.avg_memory_time,
                    avg_solve_time = chimpanzeeStats.avg_solve_time,
                    date = chimpanzeeStats.date,
                    difficulty = chimpanzeeStats.difficulty

                };

                if (entities.Chimpanzee_Stats.Add(new_stat) != null)
                {
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool insertQuizStats(Scripts.Games.QuizScript.QuizStats quizStats)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<Quiz_Stats> stats = (from stat in entities.Quiz_Stats
                                             select stat)
                .ToList();
                int last_id = stats.Count;

                var new_stat = new Quiz_Stats

                {
                    id = last_id,
                    user_id = quizStats.user_id,
                    corect_answers = quizStats.correct_answers,
                    incorect_answers = quizStats.incorrect_answers,
                    time_remaining = quizStats.minutes + quizStats.seconds/60,
                    date = quizStats.date,
                    difficulty = quizStats.difficulty

                };

                if (entities.Quiz_Stats.Add(new_stat) != null)
                {
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static List<String> getCategories()
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                List<String> categories = (from categ in entities.Categories
                                           select categ.name)
                .ToList();

                return categories;
            }
        }

        public static bool insertQuestion(Scripts.Games.QuizScript.Question question)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {

                IList<Question> questions = (from que in entities.Questions
                                     select que)
                .ToList();
                int last_id = questions.Count;

                var new_question = new Question
                {
                    id = last_id,
                    category_id = question.category_id,
                    question_text = question.question_text,
                    question_options = question.question_options,
                    question_answer = question.question_answer,
                    difficulty = question.difficulty
                };

                if (entities.Questions.Add(new_question) != null)
                {
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static int getIdOfCategory(string category)
        {
            using (ProjectEntities entities = new ProjectEntities())
            {
                var categ = entities.Categories.SingleOrDefault(c => (c.name == category));

                if (categ != null)
                {
                    return categ.id;
                }
            }
            return -1;
        }

        public static Scripts.Games.QuizScript.Question castQuestion(Question question)
        {
            return new Scripts.Games.QuizScript.Question(question.id, (int)question.category_id, question.question_text, question.question_options, question.question_answer, (int)question.difficulty);
        }

        public static List<Scripts.Games.QuizScript.Question> get_questions(string category)
        {
            // TODO: GET QUESTIONS FROM DATABASE
            int category_id = getIdOfCategory(category);
            using (ProjectEntities entities = new ProjectEntities())
            {

                IQueryable<Question> questions = entities.Questions.Where(q => q.category_id == category_id);

                List<Scripts.Games.QuizScript.Question> questions_converted = new List<Scripts.Games.QuizScript.Question>();

                foreach (Question question in questions)
                {
                    questions_converted.Add(castQuestion(question));
                }

                return questions_converted;
            }
        }
    }
}
