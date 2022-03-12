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
    public partial class ChimpanzeeTest_Window : Form
    {
        private bool hidden = false;

        ChimpanzeeTest controller;

        public ChimpanzeeTest_Window(ChimpanzeeTest controller)
        {
            InitializeComponent();

            this.controller = controller;

            clear_buttons();
        }

        private void start_Click(object sender, EventArgs e)
        {
            controller.next_stage();
            end.Enabled = false;
            next.Enabled = false;
            ((Button)sender).Hide();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Console.WriteLine("load post game");
        }

        private void next_Click(object sender, EventArgs e)
        {
            controller.next_stage();
            hidden = false;
            ((Button)sender).Enabled = false;
        }

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
        
        public void disable_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].Enabled = false;
            }
        }

        public void reveal_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].ForeColor = SystemColors.ControlText;
            }
        }

        public void next_visibility(bool visibility)
        {
            next.Enabled = visibility;
        }

        public void end_visibility(bool visibility)
        {
            end.Enabled = visibility;
        }

        private void hide_buttons()
        {
            string button_name;
            for (int i = 0; i < controller.get_number_of_cells(); i++)
            {
                button_name = "button_" + i.ToString();
                Controls[button_name].ForeColor = SystemColors.ButtonFace;
            }
        }

        public void update_buttons(List<int> seed)
        {
            clear_buttons();
            set_buttons(seed);
        }

        public void update_tries(int tries)
        {
            tries_lable.Text = "Tries: " + tries;
        }
    }
}
