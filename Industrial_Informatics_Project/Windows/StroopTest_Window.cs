using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class StroopTest_Window : Form
    {
        StroopTest controller;
        Stopwatch solve_stopwatch = new Stopwatch();

        // index of the color which need to be excluded
        // so the color name does not match the actual color of the word
        private int excludedIndex;
        public StroopTest_Window(StroopTest controller)
        {
            InitializeComponent();
            this.controller = controller;
            initializeWordLabel();
            setWordColor(controller.getRandomColor(excludedIndex));
            startTimer();
        }
        private void refreshWindow()
        {
            if (!controller.checkNoOfTries())
            {
                initializeWordLabel();
                setWordColor(controller.getRandomColor(excludedIndex));
                this.timeBar.Value = 0;
                startTimer();
            }
            else
            {
                stop_updateTime();
                controller.post_game();
            }
        }

        #region Getters
        public ProgressBar getTimeBar()
        {
            return timeBar;
        }
        #endregion

        #region Setters
        public void setWordColor(Color randomColor)
        {
            this.coloredWord.ForeColor = randomColor;
        }

        #endregion

        #region Initialize
        private void initializeWordLabel()
        {
            string randomColor = controller.getRandomColor();
            this.coloredWord.Text = randomColor;
            this.excludedIndex = controller.getIndexOfColor(randomColor);
        }

        #endregion

        #region Timer 
        private void startTimer()
        {
            this.timerPressButton = new Timer();
            this.timerPressButton.Enabled = true;
            this.timerPressButton.Start();
            solve_stopwatch.Start();
            this.timerPressButton.Interval = 1000;
            this.timeBar.Maximum = controller.getGameTime();
            this.timerPressButton.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeBar.Value != this.timeBar.Maximum)
            {
                timeBar.Value++;
            }
            else
            {
                stop_updateTime();
                refreshWindow();
            }
        }

        private void stop_updateTime()
        {
            this.timerPressButton.Stop();
            this.controller.updateTotalTime(solve_stopwatch.ElapsedMilliseconds / 1000);
            solve_stopwatch.Stop();
        }
        #endregion

        #region OnClick Events Buttons
        private void blackButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();
        }

        private void red_Button_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, coloredWord);
            stop_updateTime();
            refreshWindow();
        }
        #endregion

    }
}
