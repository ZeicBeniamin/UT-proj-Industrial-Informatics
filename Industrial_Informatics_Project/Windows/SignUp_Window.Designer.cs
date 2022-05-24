
namespace Industrial_Informatics_Project.Windows
{
    partial class SignUp_Window
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
            this.create_button = new System.Windows.Forms.Button();
            this.main_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.repassword_textbox = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.laebl_password = new System.Windows.Forms.Label();
            this.label_repassowrd = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(139, 296);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(136, 48);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "Sign up";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // main_button
            // 
            this.main_button.Location = new System.Drawing.Point(139, 367);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(136, 48);
            this.main_button.TabIndex = 1;
            this.main_button.Text = "Main Window";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.main_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(107, 170);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(206, 22);
            this.password_textbox.TabIndex = 2;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(107, 109);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(206, 22);
            this.email_textbox.TabIndex = 3;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(107, 46);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(206, 22);
            this.username_textbox.TabIndex = 4;
            // 
            // repassword_textbox
            // 
            this.repassword_textbox.Location = new System.Drawing.Point(107, 235);
            this.repassword_textbox.Name = "repassword_textbox";
            this.repassword_textbox.PasswordChar = '*';
            this.repassword_textbox.Size = new System.Drawing.Size(206, 22);
            this.repassword_textbox.TabIndex = 5;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(104, 26);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 17);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "Username";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(104, 89);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(42, 17);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email";
            // 
            // laebl_password
            // 
            this.laebl_password.AutoSize = true;
            this.laebl_password.Location = new System.Drawing.Point(107, 147);
            this.laebl_password.Name = "laebl_password";
            this.laebl_password.Size = new System.Drawing.Size(69, 17);
            this.laebl_password.TabIndex = 8;
            this.laebl_password.Text = "Password";
            // 
            // label_repassowrd
            // 
            this.label_repassowrd.AutoSize = true;
            this.label_repassowrd.Location = new System.Drawing.Point(107, 215);
            this.label_repassowrd.Name = "label_repassowrd";
            this.label_repassowrd.Size = new System.Drawing.Size(126, 17);
            this.label_repassowrd.TabIndex = 9;
            this.label_repassowrd.Text = "Conform Password";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(112, 268);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 10;
            // 
            // SignUp_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 445);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_repassowrd);
            this.Controls.Add(this.laebl_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.repassword_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.main_button);
            this.Controls.Add(this.create_button);
            this.Name = "SignUp_Window";
            this.Text = "SignUp Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_Window_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button main_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox repassword_textbox;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label laebl_password;
        private System.Windows.Forms.Label label_repassowrd;
        private System.Windows.Forms.Label label_error;
    }
}