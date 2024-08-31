using StonePaperScissors.Types;
using System;

namespace StonePaperScissors
{
    internal class Game
    {
        private int _computerScore; 
        private int _humanScore;
        private void GetSelectionfromUser(out int s)
        {
            Console.WriteLine("Make your selection");
            var selectionByHumanText = Console.ReadLine();
            //loop repeated until non-parseable input 
            while (!int.TryParse(selectionByHumanText, out s) || s < 1 || s > 3)
            {
                Console.WriteLine("Invalid selection. Please select 1 (Rock), 2 (Paper), or 3 (Scissors):");
                selectionByHumanText = Console.ReadLine();
            }
        }
        static int GetComputerChoice(Random random)
        {
            int[] choices = { 1, 2, 3 };
            return choices[random.Next(3)];
        }
        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;   
            Console.WriteLine($"=======Game Start=======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You play first");
            Console.WriteLine("1. Rock, 2. Paper, 3. Scissors");
            Random random = new Random();
            int selection = 0;
            var selectionByHuman = (Choices)selection;
            //Computer selection
            var selectionByComputer = (Choices)new Random().Next(1, 4);//exclusive of upperbound
            while (_computerScore < 10 && _humanScore < 10)
            {
                GetSelectionfromUser(out selection);
                GetComputerChoice(random);
                //loops till a selection is made from 1,2,3 //do-while also suits here
                //Human selection
                Console.WriteLine("You selected " + (Choices)selection);
                Console.WriteLine("Computer selected " + selectionByComputer);
                if(selectionByComputer == selectionByHuman)
                {
                    Console.WriteLine("It's a tie");
                }
                else if ((selectionByHuman == Choices.Stone && selectionByComputer == Choices.Scissors) ||
                        (selectionByHuman == Choices.Paper && selectionByComputer == Choices.Stone) ||
                        (selectionByHuman == Choices.Scissors && selectionByComputer == Choices.Paper))
                {
                    Console.WriteLine("You win this round!");
                    _humanScore++;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!");
                    _computerScore++;
                }

                // Display scores
                Console.WriteLine($"Score - You: {_humanScore}, Computer: {_computerScore}");
            }

            // Announce the final winner
            if (_humanScore > _computerScore)
            {
                Console.WriteLine("Congratulations! You won the game!");
            }
            else
            {
                Console.WriteLine("Computer wins the game! Better luck next time.");
            }
        }
        
    }
}
