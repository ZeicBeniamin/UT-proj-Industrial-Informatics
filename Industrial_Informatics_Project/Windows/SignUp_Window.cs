using Industrial_Informatics_Project.Scripts.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class SignUp_Window : Form
    {
        string usermane;
        string email;

        // Application object 
        Application_Controller application_controller;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="application_controller">Application object</param>
        public SignUp_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
        }

        /// <summary>
        /// Creation of a new account 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_button_Click(object sender, EventArgs e)
        {
            if(check_information())
            {
                // TO DO: INSERT INFORMATION INTO THE DATABASE
                using (var db = new GamesDBEntities1())
                {
                    Insert(db);
                }

                // If data insertion succesfull
                clear_information();
                label_error.ForeColor = Color.Green;
                label_error.Text = "Account created succesfully!";
            }
        }

        bool Insert(GamesDBEntities1 db)
        {
            bool result = false;
            var user = new User();

            user.Username = username_textbox.Text;
            user.Password = password_textbox.Text;
            user.Email = email_textbox.Text;

            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            
            return result;
        }

        bool Update(GamesDBEntities1 db)
        {
            bool result = false;

            var user = db.Users.SingleOrDefault(c => c.Username == "username");

            if (user != null)
            {
                try
                {
                    user.Username = "  ";
                    db.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }

            return result;
        }

        bool Delete(GamesDBEntities1 db, string username)
        {
            bool result = false;

            var user = db.Users.SingleOrDefault(c => c.Username == username);

            if (user != null)
            {
                try
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// Goes back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_button_Click(object sender, EventArgs e)
        {
            application_controller.open_window("Main");
        }

        /// <summary>
        /// Closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_Window_FormClosed(object sender, FormClosedEventArgs e)
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
            label_error.ForeColor = Color.Red;

            if (username_textbox.Text == "")
            {
                label_error.Text = "Please enter a valid username.";
                return false;
            }

            if (!valid_email(email_textbox.Text))
            {
                label_error.Text = "Please enter a valid email.";
                return false;
            }

            if(password_textbox.Text == "")
            {
                label_error.Text = "Please enter a valid password.";
                return false;
            }

            if (repassword_textbox.Text == "")
            {
                label_error.Text = "Please reenter your password.";
                return false;
            }

            if(repassword_textbox.Text != password_textbox.Text)
            {
                label_error.Text = "Passwords do not match.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Clear the textboxes
        /// </summary>
        private void clear_information()
        {
            username_textbox.Text = "";
            email_textbox.Text = "";
            password_textbox.Text = "";
            repassword_textbox.Text = "";    
        }

        /// <summary>
        /// Check if the email is in the correct format
        /// </summary>
        /// <param name="email">String to be checked</param>
        /// <returns>TRUE:  text is the corect format
        ///          FALSE: text is not in the correct format</returns>
        private bool valid_email(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
