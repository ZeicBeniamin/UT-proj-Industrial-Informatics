
namespace Industrial_Informatics_Project.Windows
{
    partial class PreGame_Window
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
            this.start_button = new System.Windows.Forms.Button();
            this.easy_button = new System.Windows.Forms.Button();
            this.medium_button = new System.Windows.Forms.Button();
            this.hard_button = new System.Windows.Forms.Button();
            this.difficulty_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(489, 396);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(105, 45);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // easy_button
            // 
            this.easy_button.Location = new System.Drawing.Point(28, 396);
            this.easy_button.Name = "easy_button";
            this.easy_button.Size = new System.Drawing.Size(105, 45);
            this.easy_button.TabIndex = 1;
            this.easy_button.Text = "Easy";
            this.easy_button.UseVisualStyleBackColor = true;
            this.easy_button.Click += new System.EventHandler(this.diff_button_Click);
            // 
            // medium_button
            // 
            this.medium_button.Location = new System.Drawing.Point(156, 396);
            this.medium_button.Name = "medium_button";
            this.medium_button.Size = new System.Drawing.Size(105, 45);
            this.medium_button.TabIndex = 2;
            this.medium_button.Text = "Medium";
            this.medium_button.UseVisualStyleBackColor = true;
            this.medium_button.Click += new System.EventHandler(this.diff_button_Click);
            // 
            // hard_button
            // 
            this.hard_button.Location = new System.Drawing.Point(288, 396);
            this.hard_button.Name = "hard_button";
            this.hard_button.Size = new System.Drawing.Size(105, 45);
            this.hard_button.TabIndex = 3;
            this.hard_button.Text = "Hard";
            this.hard_button.UseVisualStyleBackColor = true;
            this.hard_button.Click += new System.EventHandler(this.diff_button_Click);
            // 
            // difficulty_label
            // 
            this.difficulty_label.AutoSize = true;
            this.difficulty_label.Location = new System.Drawing.Point(28, 360);
            this.difficulty_label.Name = "difficulty_label";
            this.difficulty_label.Size = new System.Drawing.Size(157, 17);
            this.difficulty_label.TabIndex = 4;
            this.difficulty_label.Text = "Selected difficulty: Easy";
            // 
            // PreGame_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 476);
            this.Controls.Add(this.difficulty_label);
            this.Controls.Add(this.hard_button);
            this.Controls.Add(this.medium_button);
            this.Controls.Add(this.easy_button);
            this.Controls.Add(this.start_button);
            this.Name = "PreGame_Window";
            this.Text = "PreGame_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreGame_Window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button easy_button;
        private System.Windows.Forms.Button medium_button;
        private System.Windows.Forms.Button hard_button;
        private System.Windows.Forms.Label difficulty_label;
    }
}