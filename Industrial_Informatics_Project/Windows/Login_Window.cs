using Industrial_Informatics_Project.Scripts.Games;
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
    public partial class Login_Window : Form
    {
        // Application object 
        Application_Controller application_controller;

        /// <summary>
        /// Closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public Login_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
        }

        /// <summary>
        /// Open the registration window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Register");
        }

        /// <summary>
        /// Login action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_button_Click(object sender, EventArgs e)
        {
            // TO DO: logic for login
            application_controller.open_window("Main");
        }

        /// <summary>
        /// Closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Main");
        }
    }
}
