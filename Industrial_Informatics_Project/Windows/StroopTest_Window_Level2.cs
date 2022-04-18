using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class StroopTest_Window_Level2 : Form
    {
        StroopTest_Level2 controller;
        Stopwatch solve_stopwatch = new Stopwatch();
       
        public StroopTest_Window_Level2(StroopTest_Level2 controller)
        {
            InitializeComponent();
            this.controller = controller;
            initializeWordLabel();
            initializeColorLabel();
            setWordColor();
            startTimer();
            startTimerLabel();
        }
        private void refreshWindow()
        {
            if (!controller.checkNoOfTries())
            {
                initializeWordLabel();
                initializeColorLabel();
                setWordColor();
                this.timeBar.Value = 0;
                startTimer();
                startTimerLabel();
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

        public List<Label> getWordLabels()
        {
            return new List<Label>() { coloredWord1, coloredWord2, coloredWord3, coloredWord4, coloredWord5, coloredWord6 };
        }
        #endregion

        #region Setters
        public void setWordColor()
        {
            List<Color> shuffledColors = controller.getShuffledColors();
            coloredWord1.ForeColor = shuffledColors[0];
            coloredWord2.ForeColor = shuffledColors[1];
            coloredWord3.ForeColor = shuffledColors[2];
            coloredWord4.ForeColor = shuffledColors[3];
            coloredWord5.ForeColor = shuffledColors[4];
            coloredWord6.ForeColor = shuffledColors[5];
        }

        #endregion

        #region Initialize
        private void initializeWordLabel()
        {
            List<Color> shuffledColors = controller.getShuffledColors();
            coloredWord1.Text = shuffledColors[0].Name;
            coloredWord2.Text = shuffledColors[1].Name;
            coloredWord3.Text = shuffledColors[2].Name;
            coloredWord4.Text = shuffledColors[3].Name;
            coloredWord5.Text = shuffledColors[4].Name;
            coloredWord6.Text = shuffledColors[5].Name;
        }

        private void initializeColorLabel()
        {
            string randomColor = controller.getRandomColor();
            this.labelColor.Text = randomColor;
            this.labelColor.ForeColor = Color.DarkOrange;
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

        private void startTimerLabel()
        {
            this.timerMoveLabel = new Timer();
            this.timerMoveLabel.Enabled = true;
            this.timerMoveLabel.Start();
            this.timerMoveLabel.Tick += new EventHandler(timer_Tick_Label);
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

        private void timer_Tick_Label(object sender, EventArgs e)
        {
            List<Label> coloredWords = new List<Label>() {coloredWord1,coloredWord2, coloredWord3, coloredWord4, coloredWord5, coloredWord6};
            controller.moveLabel(coloredWords);
            String randomBackColor = controller.getRandomBackColor();
            controller.changeBackground(randomBackColor);
        }

        private void stop_updateTime()
        {
            this.timerPressButton.Stop();
            this.timerMoveLabel.Stop();
            this.controller.updateTotalTime(solve_stopwatch.ElapsedMilliseconds / 1000);
            solve_stopwatch.Stop();
        }
        #endregion

        #region OnClick Events Buttons
        private void blackButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();
        }

        private void red_Button_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelColor);
            stop_updateTime();
            refreshWindow();
        }

        private void StroopTest_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.pre_game();
        }
        #endregion
    }
}
