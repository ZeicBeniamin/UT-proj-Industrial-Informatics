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
        /// Gets info about the chimpanzee 
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


    }
}
