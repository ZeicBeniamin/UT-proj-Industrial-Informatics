namespace Industrial_Informatics_Project.Windows
{
    partial class StroopTest_Window_Level0
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
            this.components = new System.ComponentModel.Container();
            this.coloredWord = new System.Windows.Forms.Label();
            this.blackButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.timerPressButton = new System.Windows.Forms.Timer(this.components);
            this.timerMoveLabel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // coloredWord
            // 
            this.coloredWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.coloredWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coloredWord.Location = new System.Drawing.Point(242, 54);
            this.coloredWord.Name = "coloredWord";
            this.coloredWord.Size = new System.Drawing.Size(372, 118);
            this.coloredWord.TabIndex = 0;
            this.coloredWord.Text = "BLACK";
            // 
            // blackButton
            // 
            this.blackButton.Location = new System.Drawing.Point(173, 183);
            this.blackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(160, 64);
            this.blackButton.TabIndex = 2;
            this.blackButton.Text = "BLACK";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(340, 183);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(160, 64);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(505, 183);
            this.greenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(160, 64);
            this.greenButton.TabIndex = 4;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(173, 252);
            this.redButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(160, 64);
            this.redButton.TabIndex = 5;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.red_Button_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(339, 252);
            this.blueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(160, 64);
            this.blueButton.TabIndex = 6;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.Location = new System.Drawing.Point(505, 252);
            this.pinkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(160, 64);
            this.pinkButton.TabIndex = 7;
            this.pinkButton.Text = "PINK";
            this.pinkButton.UseVisualStyleBackColor = true;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // timeBar
            // 
            this.timeBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.timeBar.Location = new System.Drawing.Point(107, 18);
            this.timeBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(628, 18);
            this.timeBar.TabIndex = 8;
            // 
            // timerMoveLabel
            // 
            this.timerMoveLabel.Interval = 10;
            // 
            // StroopTest_Window_Level0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 364);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.coloredWord);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StroopTest_Window_Level0";
            this.Text = "StroopTest Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StroopTest_Window_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label coloredWord;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Timer timerPressButton;
        private System.Windows.Forms.Timer timerMoveLabel;
    }
}