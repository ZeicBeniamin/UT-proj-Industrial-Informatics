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
            this.coloredWord.Location = new System.Drawing.Point(272, 67);
            this.coloredWord.Name = "coloredWord";
            this.coloredWord.Size = new System.Drawing.Size(419, 147);
            this.coloredWord.TabIndex = 0;
            this.coloredWord.Text = "BLACK";
            // 
            // blackButton
            // 
            this.blackButton.Location = new System.Drawing.Point(195, 229);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(180, 80);
            this.blackButton.TabIndex = 2;
            this.blackButton.Text = "BLACK";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(382, 229);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(180, 80);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(568, 229);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(180, 80);
            this.greenButton.TabIndex = 4;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(195, 315);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(180, 80);
            this.redButton.TabIndex = 5;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.red_Button_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(381, 315);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(180, 80);
            this.blueButton.TabIndex = 6;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.Location = new System.Drawing.Point(568, 315);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(180, 80);
            this.pinkButton.TabIndex = 7;
            this.pinkButton.Text = "PINK";
            this.pinkButton.UseVisualStyleBackColor = true;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // timeBar
            // 
            this.timeBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.timeBar.Location = new System.Drawing.Point(120, 23);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(707, 23);
            this.timeBar.TabIndex = 8;
            // 
            // timerMoveLabel
            // 
            this.timerMoveLabel.Interval = 10;
            // 
            // StroopTest_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 455);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.coloredWord);
            this.Name = "StroopTest_Window";
            this.Text = "StroopTest_Window";
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