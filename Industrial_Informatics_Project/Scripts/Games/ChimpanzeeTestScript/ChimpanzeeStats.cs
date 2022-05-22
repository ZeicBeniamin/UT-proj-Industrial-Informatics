using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTestScript
{
    public class ChimpanzeeStats: GameStats
    {
        // Overall game time
        public double game_time;

        // Average mean of memorization time
        public double avg_memory_time;

        // Average meadn of the solving time 
        public double avg_solve_time;

        public int user_id;
    }
}
