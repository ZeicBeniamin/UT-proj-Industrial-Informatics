﻿using Industrial_Informatics_Project.Windows;
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
    public partial class StroopTest : Game
    {
        // Game window of the game
        private StroopTest_Window game_window;

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

        // some Game parameters
        // allocated time for each try
        private int gameTime = 5;
        private int no0fTries = 10;
        // time threshold for getting extra points (for speed)
        private int clickTimeBar = 3;
        // boolean to check the consecutive strikes
        private Boolean consecutive = false;

        public StroopTest(Application_Controller application_controller)
        {
            this.application_controller = application_controller;
            game_window = new StroopTest_Window(this);
            game_stats = new StroopStats();
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

        public void checkCorrectPress(Button pressedButton, Label word)
        {
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
                randomIndex = new Random().Next(0, colors.Count);
            } while (excludedIndex == randomIndex) ;

            return colors[randomIndex];
        }

        // get a random color from the list to initialize the label
        public String getRandomColor()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, colors.Count);
            return colors[randomIndex].Name;
        }

        // get the index of a certain color in the colors list
        public int getIndexOfColor(string color)
        {
            Color searchedColor = Color.FromName(color);
            return colors.IndexOf(searchedColor);
        }

        public void updateTotalTime(double addedTime)
        {
            this.game_stats.addToTotalTime(addedTime);
        }

        public void post_game()
        {
            game_window.Dispose();

            application_controller.set_game_stats(game_stats);

            application_controller.open_window("PostGame");
        }

    }
}
