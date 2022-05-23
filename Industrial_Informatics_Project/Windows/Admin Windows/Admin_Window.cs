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
    public partial class Admin_Window : Form
    {
        // Controller of the application 
        Application_Controller application_controller;

        public Admin_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
        }

        /// <summary>
        /// Opening the Question panel for configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addquestion_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Questions");
        }

        /// <summary>
        /// Closing the window and going back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*application_controller.exit_application();*/
            application_controller.open_window("Main");
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Categories");
        }
    }
}
