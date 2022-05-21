using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.QuizScript
{
    public class Quiz : Game
    {

        // Game statistics
        private QuizStats quiz_stats;

        // Questions from the database
        private Question[] questions;
 
        // Timer of the quiz
        private int time;

        // Number of questions 
        private int number_questions;

        // Game window of the game
        private Quiz_Window game_window;

        // Application controller
        private Application_Controller application_controller;

        /// <summary>
        /// Constructor for the quiz
        /// </summary>
        /// <param name="difficulty">Game difficulty</param>
        /// <param name="application_controller">Application controllse</param>
        public Quiz(int difficulty, Application_Controller application_controller)
        {
            set_difficulty(difficulty);

            game_window = new Quiz_Window(this);
            game_window.Show();

            this.application_controller = application_controller;

            get_categories();

            check_difficulty(difficulty);

            quiz_stats = new QuizStats();

            questions = new Question[5];

            questions[0] = new Question(0, 0, "text  mai lung la intrebare sa vad daca face wrap labelu la text daca e mai lunt aaaaaaaaaaaaaaaaaaaaaaaaaa", "d;g;h;i", "d", 1);
            questions[1] = new Question(1, 0, "nu", "d;g;h;i", "g", 1);
            questions[2] = new Question(2, 0, "poate", "d;g;h;i", "h", 1);
            questions[3] = new Question(3, 0, "sepoate", "d;g;h;i", "i", 1);
            questions[4] = new Question(4, 0, "sigur", "d;g;h;f", "f", 1);
        }

        /// <summary>
        /// Applies the difficulty 
        /// </summary>
        /// <param name="difficulty">Difficulty indicator</param>
        public void check_difficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 0:
                    {
                        number_questions = 10;
                        time = 15;
                    }; break;
                case 1:
                    {
                        number_questions = 15;
                        time = 15;
                    }; break;
                case 2:
                    {
                        number_questions  = 20;
                        time = 18;
                    }; break;
                default:
                    {
                        number_questions = 10;
                        time = 15;
                    }; break;
            }
        }

        /// <summary>
        /// Get the categories from the database and update the UI
        /// </summary>
        private void get_categories()
        {
            // TODO: ACCESS THE DATABASE FOR THE CATEGORIES
            string[] category = { "space", "math", "geography", "language", "computers", "systems", "programming", "programming", "programming", "programming", "programming", "programming", "programming", "programming", "darius" };
            game_window.update_category(category);
        }

        /// <summary>
        /// Get the qusetions from the batabase based on the difficulty and number of questions
        /// </summary>
        /// <param name="category">Category selected</param>
        public void get_questions(string category)
        {
            // TODO: GET QUESTIONS FROM DATABASE
            game_window.chage_panel(questions.Length);
        }

        /// <summary>
        /// Get the question at the index given
        /// </summary>
        /// <param name="index">Index of he question</param>
        /// <returns></returns>
        public Question get_question(int index)
        {
            return questions[index];
        }

        /// <summary>
        /// Returns the instance of the game window
        /// </summary>
        /// <returns>Game Window</returns>
        public Quiz_Window get_game_window()
        {
            return game_window;
        }

        /// <summary>
        /// Open the pre game window
        /// </summary>
        public void pre_game()
        {
            game_window.Dispose();
            application_controller.open_window("PreGame");
        }

        /// <summary>
        /// Verify if the answer is corect
        /// </summary>
        /// <param name="index"></param>
        /// <param name="answer"></param>
        internal void check_answer(int index, string answer)
        {
            questions[index].is_answerd = true;

            if(questions[index].question_answer == answer)
            {
                Console.WriteLine("Corect");
                quiz_stats.correct_answers++;
            }
            else
            {
                Console.WriteLine("Incorect");
                quiz_stats.incorrect_answers++;
            }

            if(quiz_stats.correct_answers + quiz_stats.incorrect_answers == questions.Length)
                end_game();
        }

        /// <summary>
        /// End the game and open the post game window
        /// </summary>
        public void end_game()
        {
            quiz_stats.game_name = "Quiz";
            quiz_stats.date = DateTime.Now;
            quiz_stats.difficulty = get_difficulty();

            quiz_stats.minutes = game_window.minutes;
            quiz_stats.seconds = game_window.seconds;

            application_controller.set_game_stats(quiz_stats);

            application_controller.open_window("PostGame");
        }

        /// <summary>
        /// Getter for max time (minutes)
        /// </summary>
        /// <returns>Max time</returns>
        public int get_time()
        {
            return time;
        }
    }
}
