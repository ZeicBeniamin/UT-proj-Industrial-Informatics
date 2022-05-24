using Industrial_Informatics_Project.Scripts;
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
            if (check_information())
            {
                User user = new User();
                user.id = DataModel.DataHandler.getUserId(userman_textbox.Text, password_textbox.Text);
                user.username = userman_textbox.Text;

                application_controller.set_user(user);

                if (!check_admin())
                    application_controller.open_window("Main");
                else 
                    application_controller.open_window("Admin");     
            }
        }

        /// <summary>
        /// Checkes if the admin logs on
        /// </summary>
        private bool check_admin()
        {
            if (DataModel.DataHandler.isAdmin(userman_textbox.Text, password_textbox.Text))
                return true;
            else
                return false;
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

        /// <summary>
        /// Check if the information introduced by the user is correct
        /// </summary>
        /// <returns>TRUE:  information is valid
        ///          FALSE: information is not valid</returns>
        private bool check_information()
        {
            if (userman_textbox.Text == "")
            {
                label_error.Text = "Username or password are incorect.";
                return false;
            }

            if (password_textbox.Text == "")
            {
                label_error.Text = "Username or password are incorect.";
                return false;
            }

            if (DataModel.DataHandler.isUser(userman_textbox.Text, password_textbox.Text))
                return true;
            else
                return false;
        }
    }
}
