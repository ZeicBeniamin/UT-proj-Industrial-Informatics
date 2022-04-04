
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
            this.stroop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chimpanzee_button
            // 
            this.chimpanzee_button.Location = new System.Drawing.Point(52, 136);
            this.chimpanzee_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chimpanzee_button.Name = "chimpanzee_button";
            this.chimpanzee_button.Size = new System.Drawing.Size(114, 51);
            this.chimpanzee_button.TabIndex = 0;
            this.chimpanzee_button.Text = "Chimpanzee";
            this.chimpanzee_button.UseVisualStyleBackColor = true;
            this.chimpanzee_button.Click += new System.EventHandler(this.chimpanzee_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(384, 15);
            this.register_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(93, 50);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(484, 15);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(93, 50);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // stroop_button
            // 
            this.stroop_button.Location = new System.Drawing.Point(52, 221);
            this.stroop_button.Name = "stroop_button";
            this.stroop_button.Size = new System.Drawing.Size(114, 49);
            this.stroop_button.TabIndex = 3;
            this.stroop_button.Text = "Stroop Test";
            this.stroop_button.UseVisualStyleBackColor = true;
            this.stroop_button.Click += new System.EventHandler(this.stroop_button_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 562);
            this.Controls.Add(this.stroop_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.chimpanzee_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Window";
            this.Text = "Main_Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chimpanzee_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button stroop_button;
    }
}

