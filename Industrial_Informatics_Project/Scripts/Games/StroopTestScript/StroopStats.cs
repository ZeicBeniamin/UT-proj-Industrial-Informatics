using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.StroopTestScript
{
    public partial class StroopStats : GameStats
    {
        
        // total time spend on all tries
        public double totalTime = 0;
        // no of clicks before a certain time threshold 
        public int clickedUnderBar = 0;
        // max no of consetive strikes
        public int consecutiveStrikes = 0;
        // no of correct clicks
        public int score = 0;

        public int user_id;


        public StroopStats(){
            game_name = "Stroop";
            date = DateTime.Now;
        }

        // add to total time at each step
        public void addToTotalTime(double addedTime)
        {
            this.totalTime += addedTime;
        }
      
        public void addConsecutiveStrike()
        {
            consecutiveStrikes++;
        }

        public void addClickUnderTimeBar()
        {
            clickedUnderBar++;
        }

        public void increaseScrore()
        {
            score++;
        }

        override
        public String ToString()
        {
            return ("\nGame name : " + game_name +
                "\nDate : " + date +
                "\nScore : " + score +
                "\nTotal time : " + totalTime +
                "\nClicked under the threshold : " + clickedUnderBar +
                "\nConsecutive strikes : " + consecutiveStrikes);
        }
    }
}
