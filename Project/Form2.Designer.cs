namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonGAME1 = new System.Windows.Forms.Button();
            this.buttonGAME2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGAME3 = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGAME1
            // 
            this.buttonGAME1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGAME1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGAME1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGAME1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGAME1.ForeColor = System.Drawing.Color.Black;
            this.buttonGAME1.Location = new System.Drawing.Point(459, 93);
            this.buttonGAME1.Name = "buttonGAME1";
            this.buttonGAME1.Size = new System.Drawing.Size(75, 23);
            this.buttonGAME1.TabIndex = 1;
            this.buttonGAME1.Text = "GAME1";
            this.buttonGAME1.UseVisualStyleBackColor = false;
            // 
            // buttonGAME2
            // 
            this.buttonGAME2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGAME2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGAME2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGAME2.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGAME2.ForeColor = System.Drawing.Color.Black;
            this.buttonGAME2.Location = new System.Drawing.Point(459, 160);
            this.buttonGAME2.Name = "buttonGAME2";
            this.buttonGAME2.Size = new System.Drawing.Size(75, 23);
            this.buttonGAME2.TabIndex = 2;
            this.buttonGAME2.Text = "GAME2";
            this.buttonGAME2.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(230, 254);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 33);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGAME3
            // 
            this.buttonGAME3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonGAME3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGAME3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGAME3.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGAME3.ForeColor = System.Drawing.Color.Black;
            this.buttonGAME3.Location = new System.Drawing.Point(459, 229);
            this.buttonGAME3.Name = "buttonGAME3";
            this.buttonGAME3.Size = new System.Drawing.Size(75, 23);
            this.buttonGAME3.TabIndex = 10;
            this.buttonGAME3.Text = "GAME3";
            this.buttonGAME3.UseVisualStyleBackColor = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelPassword.Location = new System.Drawing.Point(122, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(303, 45);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Choose a game";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 309);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonGAME3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGAME2);
            this.Controls.Add(this.buttonGAME1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonGAME1;
        private Button buttonGAME2;
        private Button buttonExit;
        private Button buttonGAME3;
        private Label labelPassword;
    }
}