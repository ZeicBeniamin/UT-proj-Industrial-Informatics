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
            this.SuspendLayout();
            // 
            // addquestion_button
            // 
            this.addquestion_button.Location = new System.Drawing.Point(639, 463);
            this.addquestion_button.Name = "addquestion_button";
            this.addquestion_button.Size = new System.Drawing.Size(110, 41);
            this.addquestion_button.TabIndex = 0;
            this.addquestion_button.Text = "Add Question";
            this.addquestion_button.UseVisualStyleBackColor = true;
            this.addquestion_button.Click += new System.EventHandler(this.addquestion_button_Click);
            // 
            // users_button
            // 
            this.users_button.Location = new System.Drawing.Point(38, 463);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(110, 41);
            this.users_button.TabIndex = 1;
            this.users_button.Text = "Users";
            this.users_button.UseVisualStyleBackColor = true;
            // 
            // Admin_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 534);
            this.Controls.Add(this.users_button);
            this.Controls.Add(this.addquestion_button);
            this.Name = "Admin_Window";
            this.Text = "Admin_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addquestion_button;
        private System.Windows.Forms.Button users_button;
    }
}