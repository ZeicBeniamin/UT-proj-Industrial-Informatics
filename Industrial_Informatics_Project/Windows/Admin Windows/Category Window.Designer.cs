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
            this.buttonAddCategory.Location = new System.Drawing.Point(117, 131);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(68, 46);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(365, 57);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(122, 173);
            this.listBoxCategories.TabIndex = 1;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // textBox_addCategory
            // 
            this.textBox_addCategory.Location = new System.Drawing.Point(167, 67);
            this.textBox_addCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addCategory.Name = "textBox_addCategory";
            this.textBox_addCategory.Size = new System.Drawing.Size(129, 20);
            this.textBox_addCategory.TabIndex = 2;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(52, 67);
            this.labelAddCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(96, 13);
            this.labelAddCategory.TabIndex = 3;
            this.labelAddCategory.Text = "Add New Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.textBox_addCategory);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.buttonAddCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Category_Window";
            this.Text = "Category_Window";
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