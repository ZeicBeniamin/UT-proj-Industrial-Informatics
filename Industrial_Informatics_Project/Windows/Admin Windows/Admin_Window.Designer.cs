﻿
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
            this.addquestion_button.Location = new System.Drawing.Point(479, 376);
            this.addquestion_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addquestion_button.Name = "addquestion_button";
            this.addquestion_button.Size = new System.Drawing.Size(83, 33);
            this.addquestion_button.TabIndex = 0;
            this.addquestion_button.Text = "Add Question";
            this.addquestion_button.UseVisualStyleBackColor = true;
            this.addquestion_button.Click += new System.EventHandler(this.addquestion_button_Click);
            // 
            // users_button
            // 
            this.users_button.Location = new System.Drawing.Point(29, 376);
            this.users_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(83, 33);
            this.users_button.TabIndex = 1;
            this.users_button.Text = "Users";
            this.users_button.UseVisualStyleBackColor = true;
            this.users_button.Click += new System.EventHandler(this.users_button_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(479, 306);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(83, 36);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // Admin_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.users_button);
            this.Controls.Add(this.addquestion_button);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Admin_Window";
            this.Text = "Admin Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addquestion_button;
        private System.Windows.Forms.Button users_button;
        private System.Windows.Forms.Button buttonAddCategory;
    }
}