using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games
{
    public class Game
    {
        // The class can be changed if more attributes are needed or other methods

        // Name of the game
        private string name;

        // Some information of the game, instructions on 
        // how the game should be played 
        private string game_info;

        // An indicator of how good the user played the game
        // It can be computed taking into account the difficulty choosen
        // and the stage reached by the user
        private double overall_score;

        // Difficulti indicator:
        // 0 - easy
        // 1 - medium
        // 2 - hard
        private int difficulty;
        
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Game()
        {

        }

        /// <summary>
        /// Constructor with all the information needed
        /// </summary>
        /// <param name="name">Game name</param>
        /// <param name="game_info">Game information, instructions</param>
        /// <param name="difficulty">Game difficulty</param>
        public Game(string name, string game_info, int difficulty)
        {
            this.name = name;
            this.game_info = game_info;
            this.difficulty = difficulty;
        }

        /// <summary>
        /// Game partial initialiation
        /// </summary>
        /// <param name="name">Game name</param>
        /// <param name="game_info">Game information, instructions</param>
        public Game(string name, string game_info)
        {
            this.name = name;
            this.game_info = game_info;
        }

        // I made methods for set and get 
        // C# has properties that we can use
        #region Getters and setter fot the attributes

        public void set_name(string name)
        {
            this.name = name;
        }

        public void set_game_info(string game_info)
        {
            this.game_info= game_info;
        }

        public void set_overall_score(double overall_score)
        {
            this.overall_score = overall_score;
        }

        public void set_difficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public string get_name()
        {
            return name;
        }

        public string get_game_info()
        {
            return game_info;
        }

        public double get_overall_score()
        {
            return overall_score;
        }

        public int get_difficulty()
        {
            return difficulty;
        }

        #endregion
    }
}
