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
    public partial class Dummy_Window : Form
    {
        Application_Controller application = new Application_Controller();

        public Dummy_Window()
        {
            InitializeComponent();
            application.open_window("Main");
        }
    }
}
