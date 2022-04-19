using Industrial_Informatics_Project.Scripts.Games.StroopTestScript;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Windows
{
    public partial class StroopTest_Window_Level1 : Form
    {
        StroopTest_Level1 controller;
        Stopwatch solve_stopwatch = new Stopwatch();
       
        // index of the color which need to be excluded
        // so the color name does not match the actual color of the word
        private int excludedIndexRight;
        private int excludedIndexLeft;
        public StroopTest_Window_Level1(StroopTest_Level1 controller)
        {
            InitializeComponent();
            this.controller = controller;
            initializeWordLabel();
            initializeDirectionLabel();
            setWordColor(controller.getRandomColor(excludedIndexRight), controller.getRandomColor(excludedIndexLeft));
            startTimer();
            startTimerLabel();
        }
        private void refreshWindow()
        {
            if (!controller.checkNoOfTries())
            {
                initializeWordLabel();
                initializeDirectionLabel();
                setWordColor(controller.getRandomColor(excludedIndexRight), controller.getRandomColor(excludedIndexLeft));
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

        public Label getCorectWordLabel(String left_right)
        {
            if(left_right == "RIGHT")
            {
                return coloredWordRight;
            } else
            {
                return coloredWordLeft;
            }
        }
        #endregion

        #region Setters
        public void setWordColor(Color randomColorRight,Color randomColorLeft)
        {
            // change one color if the random object selected the same values for both by chance
            if(randomColorRight == randomColorLeft)
            {
                randomColorRight = controller.getRandomColor(controller.getIndexOfColor(randomColorLeft.Name));
            }
            this.coloredWordRight.ForeColor = randomColorRight;
            this.coloredWordLeft.ForeColor = randomColorLeft;
        }

        #endregion

        #region Initialize
        private void initializeWordLabel()
        {
            string randomColorRight = controller.getRandomColor();
            string randomColorLeft = controller.getRandomColor();
            this.coloredWordRight.Text = randomColorRight;
            this.coloredWordLeft.Text = randomColorLeft;
            this.excludedIndexRight = controller.getIndexOfColor(randomColorRight);
            this.excludedIndexLeft = controller.getIndexOfColor(randomColorLeft);
        }

        private void initializeDirectionLabel()
        {
            string randomDirection = controller.getRandomDirection();
            this.labelRight_Left.Text = randomDirection;
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
            controller.moveLabel(coloredWordRight,coloredWordLeft);
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
            controller.checkCorrectPress((Button)sender, labelRight_Left);
            stop_updateTime();
            refreshWindow();

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelRight_Left);
            stop_updateTime();
            refreshWindow();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelRight_Left);
            stop_updateTime();
            refreshWindow();
        }

        private void red_Button_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelRight_Left);
            stop_updateTime();
            refreshWindow();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelRight_Left);
            stop_updateTime();
            refreshWindow();
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            controller.checkCorrectPress((Button)sender, labelRight_Left);
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
