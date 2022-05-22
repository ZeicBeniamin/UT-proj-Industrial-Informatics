using Industrial_Informatics_Project.Windows;
using Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTestScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Industrial_Informatics_Project.Scripts.Games.QuizScript;
using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using Industrial_Informatics_Project.Windows.Admin_Windows;

namespace Industrial_Informatics_Project.Scripts.Games
{
    public class Application_Controller
    {
        // Control variable used to determine if the application needs to be closed
        bool exit_app = true;

        // Game information of the selecte game
        Game game_to_play;

        // Game statistics 
        GameStats game_stats;

        // The current opened window
        Form current_form;

        // User object
        User user;

        /// <summary>
        /// Constructor
        /// </summary>
        public Application_Controller()
        {
            user = null;
            current_form = new Form();
        }

        /// <summary>
        /// Opends a new windows 
        /// </summary>
        /// <param name="windows">The windows that needs to be opend</param>
        public void open_window(string windows)
        {
            switch (windows)
            {
                case "Main": {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Main_Window(this);
                        current_form.Show();
                        exit_app = true;
                    } break;
                case "Login":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Login_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "Register":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new SignUp_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "PreGame":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new PreGame_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "PostGame":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new PostGame_Window(this);
                        ((PostGame_Window)current_form).update_stats(game_stats);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "Admin":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Admin_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "Questions":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Question_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "Categories":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Category_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "StroopStatsWindow":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Stroop_Stats_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "QuizStatsWindow":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Quiz_Stats_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "ChimpanzeeStatsWindow":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Chimpanzee_Stats_Window(this);
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                default: MessageBox.Show("Invalid windows: " + windows); break;
            }
        }

        /// <summary>
        /// Loads a specified game, the game in the Game objecct
        /// </summary>
        public void load_game()
        {
            switch (game_to_play.get_name())
            {
                case "Chimpanzee":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new ChimpanzeeTest(game_to_play.get_difficulty(), this).get_game_window();
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                case "Stroop":
                    {
                        exit_app = false;
                        current_form.Dispose();

                        if(game_to_play.get_difficulty() == 0)
                            current_form = new StroopTest_Level0(this).get_game_window();
                        else if(game_to_play.get_difficulty() == 1)
                            current_form = new StroopTest_Level1(this).get_game_window();
                        else if(game_to_play.get_difficulty() == 2)
                            current_form = new StroopTest_Level2(this).get_game_window();
                        else
                            current_form = new StroopTest_Level0(this).get_game_window();

                        current_form.Show();
                        exit_app = true;
                    }
		break;
		case "Quiz":
                    {
                        exit_app = false;
                        current_form.Dispose();
                        current_form = new Quiz(game_to_play.get_difficulty(), this).get_game_window();
                        current_form.Show();
                        exit_app = true;
                    }
                    break;
                default: MessageBox.Show("Invalid game: " + game_to_play.get_name()); break;
            }
        }

        /// <summary>
        /// Close the application if the X button is pressed  
        /// </summary>
        public void exit_application()
        {
            if (exit_app)
                Application.Exit();
        }

        /// <summary>
        /// Sets the game object with the selected game
        /// </summary>
        /// <param name="game">The object with the game Information</param>
        public void set_game_to_play(Game game)
        {
            game_to_play = game;
        }

        /// <summary>
        /// Return the game info 
        /// </summary>
        /// <returns>Game information</returns>
        public Game get_game_to_play()
        {
            return game_to_play;
        }

        public GameStats get_game_stats()
        {
            return game_stats;
        }

        /// <summary>
        /// Sets the game stats object
        /// </summary>
        /// <param name="game_stats">The stats object</param>
        public void set_game_stats(GameStats game_stats)
        {
            this.game_stats = game_stats;
        }

        /// <summary>
        /// Returns the user object
        /// </summary>
        /// <returns></returns>
        public User get_user()
        {
            return user;
        }

        /// <summary>
        /// Sets the user object
        /// </summary>
        /// <param name="user">The user object</param>
        public void set_user(User user)
        {
            this.user = user;
        }

        /// <summary>
        /// Set the difficulty for the game
        /// </summary>
        /// <param name="difficulty">The game difficulty:
        ///                            0 - esay
        ///                            1 - normal
        ///                            2 - hard</param>
        public void set_game_difficulty(int difficulty)
        {
            game_to_play.set_difficulty(difficulty);
        }
    }
}
