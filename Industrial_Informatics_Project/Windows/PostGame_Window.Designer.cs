﻿
namespace Industrial_Informatics_Project.Windows
{
    partial class PostGame_Window
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
            this.back_button = new System.Windows.Forms.Button();
            this.stats_label = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(498, 414);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(107, 59);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // stats_label
            // 
            this.stats_label.AutoSize = true;
            this.stats_label.Location = new System.Drawing.Point(68, 85);
            this.stats_label.Name = "stats_label";
            this.stats_label.Size = new System.Drawing.Size(47, 20);
            this.stats_label.TabIndex = 1;
            this.stats_label.Text = "Stats";
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(351, 414);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(108, 59);
            this.buttonStats.TabIndex = 2;
            this.buttonStats.Text = "Show Stats";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // PostGame_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 528);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.stats_label);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostGame_Window";
            this.Text = "PostGame_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostGame_Window_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label stats_label;
        private System.Windows.Forms.Button buttonStats;
    }
}