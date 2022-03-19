
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
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(142, 357);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(136, 48);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "Create account";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // main_button
            // 
            this.main_button.Location = new System.Drawing.Point(142, 411);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(136, 48);
            this.main_button.TabIndex = 1;
            this.main_button.Text = "Main Window";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.main_button_Click);
            // 
            // SignUp_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 478);
            this.Controls.Add(this.main_button);
            this.Controls.Add(this.create_button);
            this.Name = "SignUp_Window";
            this.Text = "SignUp_Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_Window_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button main_button;
    }
}