namespace Industrial_Informatics_Project.Windows
{
    partial class Quiz_Stats_Window
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
            this.cartesianChartStats = new LiveCharts.WinForms.CartesianChart();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBestStats = new System.Windows.Forms.Label();
            this.labelPerformance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartesianChartStats
            // 
            this.cartesianChartStats.Location = new System.Drawing.Point(38, 202);
            this.cartesianChartStats.Name = "cartesianChartStats";
            this.cartesianChartStats.Size = new System.Drawing.Size(745, 335);
            this.cartesianChartStats.TabIndex = 1;
            this.cartesianChartStats.Text = "cartesianChart2";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(149, 146);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(242, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Score History - Player : ";
            // 
            // labelBestStats
            // 
            this.labelBestStats.AutoSize = true;
            this.labelBestStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestStats.Location = new System.Drawing.Point(836, 228);
            this.labelBestStats.Name = "labelBestStats";
            this.labelBestStats.Size = new System.Drawing.Size(90, 25);
            this.labelBestStats.TabIndex = 3;
            this.labelBestStats.Text = "scoreline";
            this.labelBestStats.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelPerformance
            // 
            this.labelPerformance.AutoSize = true;
            this.labelPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformance.Location = new System.Drawing.Point(837, 164);
            this.labelPerformance.Name = "labelPerformance";
            this.labelPerformance.Size = new System.Drawing.Size(180, 25);
            this.labelPerformance.TabIndex = 4;
            this.labelPerformance.Text = "Best performances ";
            // 
            // Quiz_Stats_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 608);
            this.Controls.Add(this.labelPerformance);
            this.Controls.Add(this.labelBestStats);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.cartesianChartStats);
            this.Name = "Quiz_Stats_Window";
            this.Text = "QuizStatsWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChartStats;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBestStats;
        private System.Windows.Forms.Label labelPerformance;
    }
}