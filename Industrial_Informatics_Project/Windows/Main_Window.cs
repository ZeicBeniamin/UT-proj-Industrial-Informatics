using Industrial_Informatics_Project.Scripts.Games;
using Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTestScript;
using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project
{
    public partial class Main_Window : Form
    {
        // Application object 
        Application_Controller application_controller;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="application_controller">Application object</param>
        public Main_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;

            check_user_login();
        }

        #region Click events

        private void register_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Register");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Login");
        }

        /// <summary>
        /// Gets info about the chimpanzee game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chimpanzee_button_Click(object sender, EventArgs e)
        {
            Game choosen_game = new Game();
            choosen_game.set_name("Chimpanzee");

            application_controller.set_game_to_play(choosen_game);

            application_controller.open_window("PreGame");
        }
        private void stroop_button_Click(object sender, EventArgs e)
        {
            Game choosen_game = new Game();
            choosen_game.set_name("Stroop");

            application_controller.set_game_to_play(choosen_game);

            application_controller.open_window("PreGame");
        }

        /// <summary>
        /// Gets info about the quiz game 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quiz_button_Click(object sender, EventArgs e)
        {
            Game choosen_game = new Game();
            choosen_game.set_name("Quiz");

            application_controller.set_game_to_play(choosen_game);

            application_controller.open_window("PreGame");
        }

        #endregion

        /// <summary>
        /// Closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.exit_application();
        }

        /// <summary>
        /// Check if a user is logged on 
        /// </summary>
        private void check_user_login()
        {
            if (application_controller.get_user() != null)
            {
                register_button.Visible = false;
                login_button.Visible = false;

                update_for_user();

                logout_button.Visible = true;
            }
            else
            {
                register_button.Visible = true;
                login_button.Visible = true;

                logout_button.Visible = false;
            }
        }

        /// <summary>
        /// Update the user interface with the user information
        /// </summary>
        private void update_for_user()
        {
            usermane_label.Text = application_controller.get_user().username;
        }

        /// <summary>
        /// Log the user out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logout_button_Click(object sender, EventArgs e)
        {
            application_controller.set_user(null);

            application_controller.open_window("Main");
        }
    }
}
