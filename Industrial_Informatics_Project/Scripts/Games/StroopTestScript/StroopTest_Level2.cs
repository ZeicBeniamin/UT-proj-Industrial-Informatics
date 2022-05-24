using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Industrial_Informatics_Project.Scripts.Games.StroopTestScript
{
    public partial class StroopTest_Level2 : Game
    {
        // Game window of the game
        private StroopTest_Window_Level2 game_window;

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
            Color.LightSeaGreen,
            Color.PaleVioletRed,
            Color.LightSkyBlue,
            Color.LightPink,
    };

        // Random object to use further on
        static Random rand = new Random();

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

        public StroopTest_Level2(Application_Controller application_controller)
        {
            this.application_controller = application_controller;
            game_window = new StroopTest_Window_Level2(this);
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
        public List<Color> getShuffledColors()
        {
            int n = colors.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Color color = colors[k];
                colors[k] = colors[n];
                colors[n] = color;
            }
            return colors;
        }

        public void checkCorrectPress(Button pressedButton, Label label_color)
        {
            String color_word = label_color.Text;
            List<Label> coloredWords = game_window.getWordLabels();
            Label word = new Label();
            for(int i=0; i < coloredWords.Count; i++)
            {
                if(coloredWords[i].Text == color_word)
                {
                 word = coloredWords[i];
                }
            }

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
        public void moveLabel(List<Label> coloredWords)
        {
            if (coloredWords[0].Location.X <= 165 && coloredWords[0].Location.Y <= 140 && !turn)
            {
                for (int i = 0; i < coloredWords.Count; i++)
                {
                    coloredWords[i].Location = new Point(coloredWords[i].Location.X - speed, coloredWords[i].Location.Y + speed);
                }
            }
            else if (coloredWords[0].Location.X <= 130 && coloredWords[1].Location.Y >= 160 && !turn)
            {
                turn = true;
            }
            else if (turn)
            {
                for (int i = 0; i < coloredWords.Count; i++)
                {
                    coloredWords[i].Location = new Point(coloredWords[i].Location.X + speed, coloredWords[i].Location.Y - speed);
                }
                if (coloredWords[0].Location.X >= 115 && coloredWords[4].Location.Y <= 160)
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
            
            game_stats.difficulty = 2;
            DataModel.DataHandler.insertStroopStats(game_stats);

            application_controller.open_window("PostGame");
        }
    }
}
