
namespace Industrial_Informatics_Project.Windows
{
    partial class Login_Window
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
            this.login_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.userman_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(148, 222);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(112, 46);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(148, 289);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(112, 46);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "Sign up";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(112, 46);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(77, 17);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(112, 141);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(73, 17);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password:";
            // 
            // userman_textbox
            // 
            this.userman_textbox.Location = new System.Drawing.Point(115, 66);
            this.userman_textbox.Name = "userman_textbox";
            this.userman_textbox.Size = new System.Drawing.Size(181, 22);
            this.userman_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(115, 161);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(181, 22);
            this.password_textbox.TabIndex = 5;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(100, 194);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 6;
            // 
            // Login_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 372);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.userman_textbox);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.login_button);
            this.Name = "Login_Window";
            this.Text = "Login_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox userman_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label_error;
    }
}