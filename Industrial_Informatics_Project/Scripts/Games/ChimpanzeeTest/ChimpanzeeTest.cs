using Industrial_Informatics_Project.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial_Informatics_Project.Scripts.Games.ChimpanzeeTest
{
    /// <summary>
    /// The controller and logic of the chimpanzee test game
    /// </summary>
    public class ChimpanzeeTest : Game
    {
        // Number of tries the user has
        private int strikes;
        // How many buttons are avalible in the game
        private int number_of_cells = 25;
        // How many of numbers are going to be generated 
        private int number_of_numbers;

        // Number of corect guesses 
        private int numbers_corect = 0;

        // Last corect guess
        private int last_number = -1;

        // Sequence of consecutive numbers used in the random number generation
        private List<int> number_sequence = new List<int>();

        private ChimpanzeeTest_Window game_window;

        /// <summary>
        /// Initialization of the games controller
        /// </summary>
        /// <param name="difficulty">Game difficulty</param>
        public ChimpanzeeTest(int difficulty)
        {
            set_difficulty(difficulty);

            game_window = new ChimpanzeeTest_Window(this);
            game_window.Show();

            check_difficulty(difficulty);

            game_window.update_tries(strikes);
        }

        /// <summary>
        /// Generates a new stage of the game
        /// </summary>
        public void next_stage()
        {
            game_window.update_buttons(generate_seed(number_of_cells));
        }

        /// <summary>
        /// Generating a sequence of random numbers with a specific length
        /// </summary>
        /// <param name="number_of_cells">Length of the random number sequence</param>
        /// <returns>The sequence of random numbers</returns>
        private List<int> generate_seed(int number_of_cells)
        {
            List<int> seed = new List<int>();
            Random random = new Random();
            int number_index;

            init_lists();

            for (int i = 0; i < number_of_numbers; i++)
            {
                number_index = random.Next(0, number_sequence.Count);
                seed.Add(number_sequence[number_index]);
                number_sequence.RemoveAt(number_index);
            }

            return seed;
        }

        /// <summary>
        /// Initializes the consecutive number sequence used in the random generation
        /// </summary>
        private void init_lists()
        {
            number_sequence.Clear();

            for (int i = 0; i < number_of_cells; i++)
                number_sequence.Add(i);
        }

        /// <summary>
        /// Applies the difficulty 
        /// </summary>
        /// <param name="difficulty">Difficulty indicator</param>
        public void check_difficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 0: 
                    {
                        number_of_numbers = 6;
                        strikes = 3;
                    }; break;
                case 1:
                    {
                        number_of_numbers = 17;
                        strikes = 3;
                    }; break;
                case 2:
                    {
                        number_of_numbers = 25;
                        strikes = 1;
                    }; break;
                default:
                    {
                        number_of_numbers = 9;
                        strikes = 3;
                    }; break;
            }
        }

        /// <summary>
        /// Verifies if the sequence of buttons pressed is corect
        /// </summary>
        /// <param name="number">The number of the pressed button</param>
        public void new_number(int number)
        {
            if (last_number == -1 && number == 1)
            {
                last_number = number;
                return;
            }
            if (last_number != number - 1)
            {
                game_window.reveal_buttons();
                game_window.disable_buttons();
                last_number = -1;
                game_window.next_visibility(true);
                check_strikes();
            }
            else
            {
                numbers_corect++;
                if (numbers_corect == number_of_numbers-1)
                {
                    game_window.next_visibility(true);
                    numbers_corect = 0;
                    last_number = -1;
                }
                else
                    last_number = number;
            }
        }

        /// <summary>
        /// Checkes if the user has any tries left
        /// </summary>
        private void check_strikes()
        {
            if (strikes == 1)
            {
                game_window.next_visibility(false);
                game_window.end_visibility(true);
            }
            else
                strikes -= 1;
            game_window.update_tries(strikes);
        }

        // Getter for the number_of_cells
        public int get_number_of_cells()
        {
            return number_of_cells;
        }
    }
}
