namespace Industrial_Informatics_Project.Windows.Admin_Windows
{
    partial class Category_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.textBox_addCategory = new System.Windows.Forms.TextBox();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(32, 70);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(91, 57);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(360, 11);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(161, 212);
            this.listBoxCategories.TabIndex = 1;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // textBox_addCategory
            // 
            this.textBox_addCategory.Location = new System.Drawing.Point(164, 30);
            this.textBox_addCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_addCategory.Name = "textBox_addCategory";
            this.textBox_addCategory.Size = new System.Drawing.Size(171, 22);
            this.textBox_addCategory.TabIndex = 2;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(29, 30);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(129, 17);
            this.labelAddCategory.TabIndex = 3;
            this.labelAddCategory.Text = "Add New Category:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.textBox_addCategory);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.buttonAddCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Category_Window";
            this.Text = "Category Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Category_Window_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.TextBox textBox_addCategory;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.Button button1;
    }
}