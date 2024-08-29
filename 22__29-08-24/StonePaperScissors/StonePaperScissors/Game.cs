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
            while (!int.TryParse(selectionByHumanText, out s))
            {
                Console.WriteLine("Invalid selection");
                selectionByHumanText = Console.ReadLine();
            }
        }
        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;   
            Console.WriteLine($"=======Game Start=======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You play first");
            Console.WriteLine("1. Rock, 2. Paper, 3. Scissors");

            int selection = 0;
            //loops till a selection is made from 1,2,3 //do-while also suits here
            while(selection < 1 || selection > 3) 
            {
                GetSelectionfromUser(out selection);
            }
            //Human selection
            Console.WriteLine("You selected " +selection);
            //Computer selection
            var selectionByHuman = (Choices)selection;
           var selectionByComputer = (Choices)new Random().Next(1,4);//exclusive of upperbound
        }
    }
}
