using Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTest;
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
        public Main_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChimpanzeeTest controller = new ChimpanzeeTest(0);
        }
    }
}
