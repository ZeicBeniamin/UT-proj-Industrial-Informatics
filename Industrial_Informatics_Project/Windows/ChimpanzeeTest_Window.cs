using Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTest;
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
    /// <summary>
    /// Logic for the UI of the chimpanzee game
    /// </summary>
    public partial class ChimpanzeeTest_Window : Form
    {
        // Indicates if the numbers are visible or not
        private bool hidden = false;

        // Reference to the game controller
        ChimpanzeeTest controller;

        /// <summary>
        /// Initialization of the UI
        /// </summary>
        /// <param name="controller">The game controller</param>
        public ChimpanzeeTest_Window(ChimpanzeeTest controller)
        {
            InitializeComponent();

            this.controller = controller;

            clear_buttons();
        }
        
        /// <summary>
        /// Starting the game
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void start_Click(object sender, EventArgs e)
        {
            controller.next_stage();
            end.Enabled = false;
            next.Enabled = false;
            ((Button)sender).Hide();
        }

        /// <summary>
        /// Ending the game 
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void end_Click(object sender, EventArgs e)
        {
            Console.WriteLine("load post game");
        }

        /// <summary>
        /// Generates the next stage of the game
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void next_Click(object sender, EventArgs e)
        {
            controller.next_stage();
            hidden = false;
            ((Button)sender).Enabled = false;
        }

        /// <summary>
        /// Event for the game buttons, sends the number inside them to be checked 
        /// </summary>
        /// <param name="sender">The component that invoke the event</param>
        /// <param name="e">Argumesnts</param>
        private void button_Click(object sender, EventArgs e)
        {
            if(!hidden)
            {
                hide_buttons();
                hidden = true;
            }

            ((Button)sender).Enabled = false;
            controller.new_number(int.Parse(((Button)sender).Text));
        }

        /// <summary>
        /// Resets the buttons after a stage is finshed
        /// </summary>
        private void clear_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].Text = "";
                Controls[button_name].ForeColor = SystemColors.ControlText;
                Controls[button_name].Enabled = false;
            }
        }

        /// <summary>
        /// Sets the numbers in the buttons at the begining of a stage
        /// </summary>
        /// <param name="seed">What buttons need to have a number</param>
        private void set_buttons(List<int> seed)
        {
            string button_name;
            for (int i = 0; i < seed.Count; i++)
            {
                button_name = "button_" + seed[i].ToString();
                Controls[button_name].Text = (i + 1).ToString();
                Controls[button_name].Enabled = true;
            }
        }
        
        /// <summary>
        /// Disables all the button
        /// </summary>
        public void disable_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].Enabled = false;
            }
        }

        /// <summary>
        /// Shows the text inside the buttons
        /// </summary>
        public void reveal_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].ForeColor = SystemColors.ControlText;
            }
        }

        /// <summary>
        /// Sets the visibility o the next button
        /// </summary>
        /// <param name="visibility">True o false</param>
        public void next_visibility(bool visibility)
        {
            next.Enabled = visibility;
        }

        /// <summary>
        /// Sets the visibility o the end button
        /// </summary>
        /// <param name="visibility">True o false</param>
        public void end_visibility(bool visibility)
        {
            end.Enabled = visibility;
        }

        /// <summary>
        /// Hides the text inside the buttons
        /// </summary>
        private void hide_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].ForeColor = SystemColors.ButtonFace;
            }
        }

        /// <summary>
        /// Sets up the buttons at the beginnig of a stage
        /// </summary>
        /// <param name="seed">What buttons need to have a number in them</param>
        public void update_buttons(List<int> seed)
        {
            clear_buttons();
            set_buttons(seed);
        }


        /// <summary>
        /// Updates the tries label 
        /// </summary>
        /// <param name="tries">Number of tries left</param>
        public void update_tries(int tries)
        {
            tries_lable.Text = "Tries: " + tries;
        }
    }
}
