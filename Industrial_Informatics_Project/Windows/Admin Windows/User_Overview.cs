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

namespace Industrial_Informatics_Project.Windows.Admin_Windows
{
    public partial class User_Overview : Form
    {
        Application_Controller application_controller = null;
        public User_Overview(Application_Controller application_controller )
        {
            InitializeComponent();
            this.application_controller = application_controller;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void User_Overview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iI_ProjectDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iI_ProjectDataSet.Users);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void onUserOverviewClosed(object sender, FormClosedEventArgs e)
        {
            application_controller.open_window("Admin");
        }
    }
}
