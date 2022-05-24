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
        private List<Question> questions;
 
        // Timer of the quiz
        private int time;

        // Required number of questions
        private int required_number_questions;

        // Actual number of questions
        // If there are not enough questions from a given category, 
        // required_number_questions will be less than number_questions
        // Good for errors that might appear when inserting new 
        // categories.
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
            quiz_stats.user_id = application_controller.get_user().id;

            //questions = new Question[5];

           // questions[0] = new Question(0, 0, "text  mai lung la intrebare sa vad daca face wrap labelu la text daca e mai lunt aaaaaaaaaaaaaaaaaaaaaaaaaa", "d;g;h;i", "d", 1);
            //questions[1] = new Question(1, 0, "nu", "d;g;h;i", "g", 1);
            //questions[2] = new Question(2, 0, "poate", "d;g;h;i", "h", 1);
            //questions[3] = new Question(3, 0, "sepoate", "d;g;h;i", "i", 1);
            //questions[4] = new Question(4, 0, "sigur", "d;g;h;f", "f", 1);
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
                        required_number_questions = 10;
                        time = 10;
                    }; break;
                case 1:
                    {
                        required_number_questions = 10;
                        time = 10;
                    }; break;
                case 2:
                    {
                        required_number_questions = 10;
                        time = 10;
                    }; break;
                default:
                    {
                        required_number_questions = 10;
                        time = 10;
                    }; break;
            }
        }

        /// <summary>
        /// Get the categories from the database and update the UI
        /// </summary>
        private void get_categories()
        {
            // TODO: ACCESS THE DATABASE FOR THE CATEGORIES
            List<String> categories = DataModel.DataHandler.getCategories();
            game_window.update_category(categories);
        }

        /// <summary>
        /// Get the qusetions from the batabase based on the difficulty and number of questions
        /// </summary>
        /// <param name="category">Category selected</param>
        public void get_questions(string category)
        {
            // Initialize a random generator for random question order
            var rnd = new Random(DateTime.Now.Millisecond);

            // Get questions from db, having a certain difficulty
            questions = DataModel.DataHandler.get_questions(category, application_controller.get_game_to_play().get_difficulty());
            
            //  Initialize empty list of questions in random order
            List<Scripts.Games.QuizScript.Question> random_questions = new List<Scripts.Games.QuizScript.Question>();

            // Set the number of questions to match the required number of questions
            // If we do not have enough questions in the DB, the number will be lowered
            number_questions = required_number_questions;

            // Check if we have enough questions in the db. Otherwise, lower the number
            // of questions.
            if (questions.Count < number_questions)
            { 
                number_questions = questions.Count;
                Console.WriteLine("We only have " + number_questions + " questions.");
            }

            // Maintain a marking of the questions already selected - prevents selecting a question two times
            int[] already_selected = new int[questions.Count];
            // Build a vector of randomly selected questions, constantly checking that the
            // currently selected question was not previously selected.
            while (random_questions.Count != number_questions)
            {
                int idx = rnd.Next(0, questions.Count);
                if (already_selected[idx] == 0)
                {
                    already_selected[idx] = 1;
                    random_questions.Add(questions[idx]);
                }
            }

            // If no questions were found in the database, do not open the next window
            if (number_questions != 0)
            {
                game_window.change_panel(random_questions.Count);
            }
            else
            {
                return;
            }
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

            if(quiz_stats.correct_answers + quiz_stats.incorrect_answers == number_questions)
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

            DataModel.DataHandler.insertQuizStats(quiz_stats);

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
