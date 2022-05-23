using Industrial_Informatics_Project.Scripts.Games;
using Industrial_Informatics_Project.Scripts.Games.QuizScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows.Admin_Windows
{
    public partial class Question_Window : Form
    {
        // Contoller of the application
        Application_Controller application_controller;

        public Question_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
            addToCategories(DataModel.DataHandler.getCategories());
        }

        /// <summary>
        /// Closing the window and going back 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Question_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Admin");
        }

        /// <summary>
        /// Clears all the test boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_controles();
        }

        /// <summary>
        /// Addes the question to the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_button_Click(object sender, EventArgs e)
        {
            if (check_textBox())
            {
                string answer = "";
                string options = option_one_richTextBox.Text.Trim() + ";" + option_two_richTextBox.Text.Trim() + ";" + option_three_richTextBox.Text.Trim() + ";" + option_four_richTextBox.Text.Trim();
                var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                switch (((RadioButton)checkedButton).Name)
                {   
                    case "option_one_radio": answer = option_one_richTextBox.Text.Trim(); break;
                    case "option_two_radio": answer = option_two_richTextBox.Text.Trim(); break;
                    case "option_three_radio": answer = option_three_richTextBox.Text.Trim(); break;
                    case "option_four_radio": answer = option_four_richTextBox.Text.Trim(); break;
                }

                Question question = new Question(0, category_comboBox.SelectedIndex, question_richTextBox.Text.Trim(), options, answer, difficulty_comboBox.SelectedIndex);

                // INSERT QUSETION 
                DataModel.DataHandler.insertQuestion(question);

                clear_controles();
                MessageBox.Show(question.ToString());
            }
            else
                MessageBox.Show("Please check all the information given.");
        }
        
        /// <summary>
        /// Chekes if all the textBoxes have text in them
        /// </summary>
        private bool check_textBox()
        {
            if (question_richTextBox.Text == "")
                return false;
            if (option_one_richTextBox.Text == "")
                return false;
            if (option_two_richTextBox.Text == "")
                return false;
            if (option_four_richTextBox.Text == "")
                return false;
            if (Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) == null)
                return false;
            if (category_comboBox.SelectedIndex == -1)
                return false;
            if (difficulty_comboBox.SelectedIndex == -1)
                return false;
            return true;
        }

        /// <summary>
        /// Clear textboxes and uncheck radio buttons
        /// </summary>
        private void clear_controles()
        {
            question_richTextBox.Text = "";
            option_one_richTextBox.Text = "";
            option_two_richTextBox.Text = "";
            option_three_richTextBox.Text = "";
            option_four_richTextBox.Text = "";

            option_one_radio.Checked = false;
            option_two_radio.Checked = false;
            option_three_radio.Checked = false;
            option_four_radio.Checked = false;
        }

        private void addToCategories(List<String> categories)
        {
            foreach (String category in categories)
            {
                category_comboBox.Items.Add(category);
            }
        }

    }
}
