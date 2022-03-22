using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private String coloredWord;
        private int gameTime;

    }
}
