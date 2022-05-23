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
    public partial class Category_Window : Form
    {

        // Contoller of the application
        Application_Controller application_controller;

        public Category_Window(Application_Controller application_controller)
        {
            InitializeComponent();
            this.application_controller = application_controller;
            addToCategories();
        }

        /// <summary>
        /// Closing the window and going back 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Category_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Admin");
        }
  

        private void addToCategories()
        {
            List<String> categories = DataModel.DataHandler.getCategories();
            listBoxCategories.Items.Clear();
            foreach (String category in categories)
            {
                listBoxCategories.Items.Add(category);
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if(textBox_addCategory.Text != "")
            {
                DataModel.DataHandler.insertCategory(textBox_addCategory.Text);
            }
            addToCategories();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBoxCategories.SelectedIndex != -1) // No item selected if idx == -1
            {
                DataModel.DataHandler.deleteCategory(listBoxCategories.Text);
            }
            addToCategories();
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Category_Window_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            application_controller.open_window("Admin");
        }
    }
}
