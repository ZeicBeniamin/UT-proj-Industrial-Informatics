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

namespace Industrial_Informatics_Project.Windows
{
    public partial class Quiz_Window : Form
    {
        // Timer 
        public int minutes;
        public int seconds;

        // Last selected question
        private int last_selected_question = -1;

        // Controller of the quiz game
        private Quiz controller;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="controller">Controller of the game</param>
        public Quiz_Window(Quiz controller)
        {
            InitializeComponent();

            this.controller = controller;

            set_window();

            question_text_label.MaximumSize = new Size(500, 0);
            question_text_label.AutoSize = true;
        }

        /// <summary>
        /// Set inital state of the window
        /// </summary>
        private void set_window()
        {
            quiz_panel.Visible = false;
            category_select_panel.Visible = true;
        }

        /// <summary>
        /// Create the buttons for the categories
        /// </summary>
        /// <param name="categories"></param>
        public void update_category(List<String> categories)
        {
            for(int i=0;i<categories.Count;i++)
            {
                Button button = new Button();
                button.Height = 50;
                button.Width = 100;
                button.Text = categories[i];
                button.Click += new EventHandler(category_button_click);

                category_buttons_panel.Controls.Add(button);
            }
        }
        /// <summary>
        /// Update the selection for the questions
        /// </summary>
        /// <param name="category"></param>
        public void update_selections(int number_questions)
        {
            for (int i = 0; i < number_questions; i++)
            {
                Button button = new Button();
                button.Height = 50;
                button.Width = 50;
                button.Text = i.ToString();
                button.BackColor = Color.Gray;
                button.Click += new EventHandler(selection_button_click);

                qusetion_selection_panel.Controls.Add(button);
            }
        }

        /// <summary>
        /// Change from the category selection to the actual quiz game 
        /// </summary>
        /// <param name="number_qusetion"></param>
        public void change_panel(int number_qusetion)
        {
            quiz_panel.Visible = true;
            category_select_panel.Visible = false;

            update_selections(number_qusetion);

            selection_button_click(qusetion_selection_panel.Controls[0], EventArgs.Empty);

            minutes = controller.get_time();
            seconds = 0;

            countdown_timer.Start();
            update_timer();
        }

        /// <summary>
        /// Question selection event
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void selection_button_click(object sender, EventArgs e)
        {
            question_panel.Enabled = true;
            uncheck_radio();

            if (last_selected_question != -1)
            {
                Button button = (Button)qusetion_selection_panel.Controls[last_selected_question];
                if(!controller.get_question(last_selected_question).is_answerd)
                    button.BackColor = Color.Gray;
            }

            if (!controller.get_question(int.Parse(((Button)sender).Text)).is_answerd)
                ((Button)sender).BackColor = Color.Aqua;

            last_selected_question = int.Parse(((Button)sender).Text);
            update_question(controller.get_question(last_selected_question));
        }

        /// <summary>
        /// Uncheck radio buttons 
        /// </summary>
        private void uncheck_radio()
        {
            option_one.Checked = false;
            option_two.Checked = false;
            option_three.Checked = false;
            option_four.Checked = false;
        }

        /// <summary>
        /// Update the quiestion panel
        /// </summary>
        /// <param name="question">Information about the panel</param>
        private void update_question(Question question)
        {
            question_text_label.Text = question.question_text;

            string[] options = question.question_options.Split(';');
            option_one.Text = options[0];
            option_two.Text = options[1];
            option_three.Text = options[2];
            option_four.Text = options[3];

            if (question.is_answerd)
                question_panel.Enabled = false;

        }

        /// <summary>
        /// Event for category button click
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void category_button_click(object sender, EventArgs e)
        {
            category_label.Text = ((Button)sender).Text;
            controller.get_questions(((Button)sender).Text);
        }

        /// <summary>
        /// X button was pressed and load pre-game window
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void Quiz_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.pre_game();
        }

        /// <summary>
        /// EWvent of the lock answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answer_button_Click(object sender, EventArgs e)
        {
            var checkedButton = question_panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                ((Button)qusetion_selection_panel.Controls[last_selected_question]).BackColor = Color.Red;

                question_panel.Enabled = false;

                controller.check_answer(last_selected_question, ((RadioButton)checkedButton).Text);
            }
        }

        /// <summary>
        /// Event for elaps time of timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countdown_timer_Tick(object sender, EventArgs e)
        {
            if (minutes == 0 && seconds == 0)
            {
                controller.end_game();
                countdown_timer.Stop();
            }

            if (seconds == 0)
            {
                minutes--;
                seconds = 59;
            }
            else
                seconds--;

            update_timer();
        }

        /// <summary>
        /// Update the timer label
        /// </summary>
        private void update_timer()
        {
            if (minutes < 10)
                timer_label.Text = "0" + minutes.ToString() + ":";
            else
                timer_label.Text = minutes.ToString() + ":";

            if (seconds < 10)
                timer_label.Text += "0" + seconds.ToString();
            else
                timer_label.Text += seconds.ToString();
        }

        private void quiz_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
