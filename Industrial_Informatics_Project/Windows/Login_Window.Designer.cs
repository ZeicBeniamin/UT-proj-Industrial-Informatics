
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
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(147, 355);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(112, 46);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(147, 407);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(112, 46);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "Cerate Account";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Login_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 483);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.login_button);
            this.Name = "Login_Window";
            this.Text = "Login_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_button;
    }
}