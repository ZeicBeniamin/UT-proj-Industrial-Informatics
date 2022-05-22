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
            this.SuspendLayout();
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(176, 202);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(102, 71);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 20;
            this.listBoxCategories.Location = new System.Drawing.Point(547, 87);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(181, 264);
            this.listBoxCategories.TabIndex = 1;
            // 
            // textBox_addCategory
            // 
            this.textBox_addCategory.Location = new System.Drawing.Point(250, 103);
            this.textBox_addCategory.Name = "textBox_addCategory";
            this.textBox_addCategory.Size = new System.Drawing.Size(191, 26);
            this.textBox_addCategory.TabIndex = 2;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(78, 103);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(141, 20);
            this.labelAddCategory.TabIndex = 3;
            this.labelAddCategory.Text = "Add New Category";
            // 
            // Category_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.textBox_addCategory);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.buttonAddCategory);
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
    }
}