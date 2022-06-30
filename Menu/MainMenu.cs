using GuessNumberGame;
using RockPaperScissors;
using RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    public class MainMenu
    {
        public void Start()
        {
            RunMainMenu();
        }

        public void RunMainMenu()
        {
            string[] options = { "Games", "About", "Exit" };
            string[] description = {"A bunch of Console Games","About this Project","To leave"};
            Menu menu = new Menu("Title as a test", options, description);
            int selectedIndex = menu.Run();
            
            switch(selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1: 
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("Easter Egg");
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoice()
        {
            string[] options = { "Guess Number", "Rock Paper Scissors", "RPG", "Go back" };
            string[] description = {"A Guessing Game", "VS Computer", "RolePlay Game", "Back to Main Menu"};
            Menu menu = new Menu("Games", options,description);
            int selectedIndex = menu.Run();

            GuessGame guess = new GuessGame();
            RockPaperScissorsGame rockPaperScissorsGame = new RockPaperScissorsGame();
            RolePlayGame rolePlayGame = new RolePlayGame();
            
            Console.Clear();
            switch (selectedIndex)
            {
                case 0:
                    
                    guess.Start();
                    break;
                case 1:
                    rockPaperScissorsGame.Start();
                    break;
                case 2:
                    rolePlayGame.Start();
                    break;
                case 3:
                    RunMainMenu();
                    break;
            }
            RunFirstChoice();
        }
    }
}
