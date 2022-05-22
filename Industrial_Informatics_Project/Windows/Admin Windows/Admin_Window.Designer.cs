
namespace Industrial_Informatics_Project.Windows
{
    partial class Admin_Window
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
            this.addquestion_button = new System.Windows.Forms.Button();
            this.users_button = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addquestion_button
            // 
            this.addquestion_button.Location = new System.Drawing.Point(719, 579);
            this.addquestion_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addquestion_button.Name = "addquestion_button";
            this.addquestion_button.Size = new System.Drawing.Size(124, 51);
            this.addquestion_button.TabIndex = 0;
            this.addquestion_button.Text = "Add Question";
            this.addquestion_button.UseVisualStyleBackColor = true;
            this.addquestion_button.Click += new System.EventHandler(this.addquestion_button_Click);
            // 
            // users_button
            // 
            this.users_button.Location = new System.Drawing.Point(43, 579);
            this.users_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(124, 51);
            this.users_button.TabIndex = 1;
            this.users_button.Text = "Users";
            this.users_button.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(719, 471);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(124, 56);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // Admin_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 668);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.users_button);
            this.Controls.Add(this.addquestion_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_Window";
            this.Text = "Admin_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addquestion_button;
        private System.Windows.Forms.Button users_button;
        private System.Windows.Forms.Button buttonAddCategory;
    }
}