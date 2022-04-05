
namespace Industrial_Informatics_Project
{
    partial class Main_Window
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
            this.chimpanzee_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.usermane_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chimpanzee_button
            // 
            this.chimpanzee_button.Location = new System.Drawing.Point(46, 109);
            this.chimpanzee_button.Name = "chimpanzee_button";
            this.chimpanzee_button.Size = new System.Drawing.Size(101, 41);
            this.chimpanzee_button.TabIndex = 0;
            this.chimpanzee_button.Text = "Chimpanzee";
            this.chimpanzee_button.UseVisualStyleBackColor = true;
            this.chimpanzee_button.Click += new System.EventHandler(this.chimpanzee_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(341, 12);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(83, 40);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(430, 12);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(83, 40);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(430, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(83, 40);
            this.logout_button.TabIndex = 4;
            this.logout_button.Text = "LogOut ";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Visible = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // usermane_label
            // 
            this.usermane_label.AutoSize = true;
            this.usermane_label.Location = new System.Drawing.Point(43, 24);
            this.usermane_label.Name = "usermane_label";
            this.usermane_label.Size = new System.Drawing.Size(0, 17);
            this.usermane_label.TabIndex = 5;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.usermane_label);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.chimpanzee_button);
            this.Name = "Main_Window";
            this.Text = "Main_Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chimpanzee_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label usermane_label;
    }
}

