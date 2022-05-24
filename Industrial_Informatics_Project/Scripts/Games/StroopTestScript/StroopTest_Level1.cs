using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Scripts.Games.StroopTestScript
{
    public partial class StroopTest_Level1 : Game
    {
        // Game window of the game
        private StroopTest_Window_Level1 game_window;

        // Application controller
        private Application_Controller application_controller;

        // Game stats 
        private StroopStats game_stats;

        // List of colors used
        private List<Color> colors = new List<Color>()
        {
            Color.Black,
            Color.Yellow,
            Color.Green,
            Color.Red,
            Color.Blue,
            Color.Pink,
    };
        // List of right/left directions to choose from
        private List<String> directions = new List<String>(){ "RIGHT", "LEFT",};
        
        // List of colors used
        private List<Color> backgroundColors = new List<Color>()
        {
            Color.DarkGray,
            Color.LightYellow,
            Color.ForestGreen,
            Color.PaleVioletRed,
            Color.DeepSkyBlue,
            Color.HotPink,
    };
        // Random object to use further on
        Random rand = new Random();

        // some Game parameters
        // allocated time for each try
        private int gameTime = 5;
        private int no0fTries = 10;
        // time threshold for getting extra points (for speed)
        private int clickTimeBar = 3;
        // boolean to check the consecutive strikes
        private Boolean consecutive = false;

        // variable used for Label movement in the view
        Boolean turn = false;
        int speed = 10;

        public StroopTest_Level1(Application_Controller application_controller)
        {
            this.application_controller = application_controller;
            game_window = new StroopTest_Window_Level1(this);
            game_stats = new StroopStats();
            game_stats.user_id = application_controller.get_user().id;
        }

        #region Getters
        public Form get_game_window()
        {
            return game_window;
        }

        public StroopStats getStats()
        {
            return this.game_stats;
        }
        public int getGameTime()
        {
            return this.gameTime;
        }

        #endregion

        public void checkCorrectPress(Button pressedButton, Label left_right_label)
        {
            Label word;
            word = this.game_window.getCorectWordLabel(left_right_label.Text);

            if(pressedButton.Name == (word.ForeColor.Name.ToLower() + "Button"))
            {
                game_stats.increaseScrore();
                if(game_window.getTimeBar().Value <= clickTimeBar)
                    {
                    game_stats.addClickUnderTimeBar();
                    }
                if (consecutive)
                    {
                    game_stats.addConsecutiveStrike();
                    }
                else
                    {
                    consecutive = true;
                    }
            }
            else
            {
                consecutive = false;
            }
            no0fTries--;
        }

        public Boolean checkNoOfTries()
        {
            return (no0fTries == 0);
        }

        // get a random color from the colors list, 
        // but  not the color written on the label
        public Color getRandomColor(int excludedIndex)
        {
            int randomIndex;
            do {
                randomIndex = rand.Next(0, colors.Count);
            } while (excludedIndex == randomIndex) ;

            return colors[randomIndex];
        }

        // get a random color from the list to initialize the label
        public String getRandomColor()
        {
            int randomIndex = rand.Next(0, colors.Count);
            return colors[randomIndex].Name;
        }

        // get a random background color for the window
        public String getRandomBackColor()
        {
            int randomIndex = rand.Next(0, backgroundColors.Count);
            return backgroundColors[randomIndex].Name;
        }

        // get a random background color for the window
        public String getRandomDirection()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, directions.Count);
            return directions[randomIndex];
        }

        // get the index of a certain color in the colors list
        public int getIndexOfColor(string color)
        {
            Color searchedColor = Color.FromName(color);
            return colors.IndexOf(searchedColor);
        }

        // update the total time spend 
        public void updateTotalTime(double addedTime)
        {
            this.game_stats.addToTotalTime(addedTime);
        }

        // word labels moving implementation for the view
        public void moveLabel(Label coloredWordRight,Label coloredWordLeft)
        {
            if (coloredWordRight.Location.X >= 350 && !turn)
            {
                coloredWordRight.Location = new Point(coloredWordRight.Location.X - speed, coloredWordRight.Location.Y);
                coloredWordLeft.Location = new Point(coloredWordLeft.Location.X + speed, coloredWordLeft.Location.Y);
            }
            else if (coloredWordRight.Location.X < 350 && !turn)
            {
                turn = true;
            }
            else if (turn)
            {
                coloredWordRight.Location = new Point(coloredWordRight.Location.X + speed, coloredWordRight.Location.Y);
                coloredWordLeft.Location = new Point(coloredWordLeft.Location.X - speed, coloredWordLeft.Location.Y);
                if (coloredWordRight.Location.X > 460)
                    turn = false;
            }
        }

        // change of background for the view
        public void changeBackground(String backgroundColor)
        {
            game_window.BackColor = Color.FromName(backgroundColor);
        }

        public void pre_game()
        {
            game_window.Dispose();
            application_controller.open_window("PreGame");
        }

        public void post_game()
        {
            game_window.Dispose();

            application_controller.set_game_stats(game_stats);

            game_stats.difficulty = 1;
            DataModel.DataHandler.insertStroopStats(game_stats);

            application_controller.open_window("PostGame");
        }

    }
}
