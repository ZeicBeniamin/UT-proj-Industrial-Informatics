using Industrial_Informatics_Project.Scripts.Games;
using Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTestScript;
using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class PostGame_Window : Form
    {
        // Application object 
        Application_Controller application_controller;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="application_controller">Application object</param>
        public PostGame_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
        }

        public void update_stats(GameStats game_stats)
        {
            switch(game_stats.game_name)
            {
                case "Chimpaznee":
                    {
                        stats_label.Text = "Game name: " + ((ChimpanzeeStats)game_stats).game_name + "\nGame time: " + ((ChimpanzeeStats)game_stats).game_time;
                        stats_label.Text += "\nMax level: " + ((ChimpanzeeStats)game_stats).level + "\nMemory average: " + ((ChimpanzeeStats)game_stats).avg_memory_time;
                        stats_label.Text += "\nSolve average: " + ((ChimpanzeeStats)game_stats).avg_solve_time+ "\nDate: " + ((ChimpanzeeStats)game_stats).date;
                        stats_label.Text += "\nDifficulty: " + ((ChimpanzeeStats)game_stats).difficulty;
                    }
                    break;

                case "Stroop":
                    {
                        stats_label.Text = ((StroopStats)game_stats).ToString(); 
                    }
                    break;
            }
        }

        /// <summary>
        /// Opens the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Main");
        }

        /// <summary>
        /// Closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PostGame_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Main");
        }
    }
}
