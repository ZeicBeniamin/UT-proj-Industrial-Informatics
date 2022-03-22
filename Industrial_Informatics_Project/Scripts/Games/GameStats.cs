using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games
{
    public abstract class GameStats
    {
        // Name of the game
        public string game_name;

        // Level reached by the user
        public int level;

        // When the game was played
        public DateTime date;

        // Difficulty of the game
        public int difficulty;
    }
}
