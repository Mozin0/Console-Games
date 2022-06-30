using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class RolePlayGame
    {
        public void Start()
        {
            string userName = Environment.UserName;
            Player player = new Player(userName);

            string[] classes = { "Warrior", "Mage", "Archer" };
            string[] battle = { "Clashed", "Pierced" };
            int spins = 3;


            Console.WriteLine($"Welcome {userName}, This is an RPG game where you can either become either the strongest or die the weakest");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"There are {classes.Length} classes to choose from");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine("The classes are:");
            foreach (string s in classes)
            {
                Console.Write($"{s}\n");
            }
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine("Press S to spin for your class");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"You have {spins} spins remaining.");

            string chosenClass;

            while (true)
            {
                if (Console.ReadKey(true).Key != ConsoleKey.S)
                    continue;
                chosenClass = randomClass();

                spins--;
                if (spins == 0)
                {
                    Console.Error.WriteLine("You have ran out of spins.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You have {spins} spins remaining.");
                }
            }
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"Well Well Well, it seems you are a {chosenClass} ");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"Now you are ready to explore the world on your own {chosenClass}");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine("You will face many enemies and monsters along the way but aslong as you train hard and fight your way to the top, nothing will be able to stop you ");
            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"To start your journey you just have to walk out that door, good luck");
            enterToContinue();
            Console.Clear();
            string John = "John";
            var PlayerJohn = Player.CreatePlayer(John);
            Console.WriteLine(John);
            PlayerJohn.ShowStatus(John);

            Console.Write($"{userName} You have come across a {John} ");

            enterToContinue();
            ClearLastLineWrittenByConsole();

            Console.WriteLine($"{John}: What are you looking at weakling");
            Console.WriteLine("Please press one of the buttons below to pick a response:");

            Console.WriteLine("1: Who me?");
            Console.WriteLine("2: Your the only weakling here!");
            Console.WriteLine("3: Shut up!");

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    Console.WriteLine($"{userName}: Who me?");
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    Console.WriteLine($"{userName}: Your the only weakling here!");
                    break;
                }
                else if (key == ConsoleKey.D3)
                {
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    Console.WriteLine($"{userName}: Shut up!");
                    break;
                }
                else if (key is not ConsoleKey.D1 && key is not ConsoleKey.D2 && key is not ConsoleKey.D3)
                {
                    continue;
                }
            }

            Console.WriteLine($"{John}: HUUH! Are you questioning me, lets have duel");
            Console.WriteLine("Please press one of the buttons below to pick a response:");

            Console.WriteLine("1: Lets do it!");
            Console.WriteLine("2: Na im good zzzz");

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.D1)
                {
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    Console.WriteLine($"{userName}: Lets do it!");
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    ClearLastLineWrittenByConsole();
                    Console.WriteLine($"{userName}: Na im good zzzz");
                    break;
                }
                else if (key is not ConsoleKey.D1 && key is not ConsoleKey.D2)
                {
                    continue;
                }
            }

            Task.Delay(1000).Wait();
            Console.Clear();

            Console.WriteLine("Duel Commencing...");

            Task.Delay(4000).Wait();
            Console.WriteLine("FIGHT!");

            Fighting();

            Console.WriteLine("This is the end of the demo game V(0.1)");

            void Fighting()
            {
                Player player1 = new(userName);
                player1.Fight(PlayerJohn);
            }

            static void ClearLastLineWrittenByConsole()
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.Write(new string(' ', Console.BufferWidth));

                Console.SetCursorPosition(0, Console.CursorTop);
            }

            string randomClass()
            {
                var playerClassName = Player.CreatePlayer(player.Name);
                string playerClass = $"{playerClassName.GetType().Name}";
                Console.WriteLine(playerClass);
                return playerClass;
            }
            void enterToContinue()
            {
                Console.WriteLine("Press Enter to continue, please.");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            }

        }
    }
}
