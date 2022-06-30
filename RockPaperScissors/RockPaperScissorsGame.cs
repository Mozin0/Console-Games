using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        public void Start()
        {
            string[] game = {
                "Rock","Paper","Scissor"
                };

            int loss = 0;
            int win = 0;
            int draw = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Rock Paper Scissors");
                Console.WriteLine("Choose R for rock, P for paper or S for Scissors");

                var readKey = Console.ReadKey(true).Key;
                if (readKey is not ConsoleKey.S &&
                    readKey is not ConsoleKey.P &&
                    readKey is not ConsoleKey.R &&
                    readKey is not ConsoleKey.Escape)
                {
                    Console.WriteLine("Please pick a key from above");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                string computerMove = randomMethod();

                if (readKey == ConsoleKey.R)
                {
                    Console.WriteLine("You have picked Rock");

                    if (game[0] == computerMove)
                    {
                        draw++;
                        Console.WriteLine("You Draw");
                    }
                    else if (game[1] == computerMove)
                    {
                        loss++;
                        Console.WriteLine("You Lose");

                    }
                    else
                    {
                        win++;
                        Console.WriteLine("You Win");
                    }
                    Console.WriteLine($"Score: {win} wins, {loss} losses and {draw} draws");
                }

                else if (readKey == ConsoleKey.P)
                {
                    Console.WriteLine("You have picked Paper");
                    if (game[0] == computerMove)
                    {
                        win++;
                        Console.WriteLine("You Win");
                    }
                    else if (game[1] == computerMove)
                    {
                        draw++;
                        Console.WriteLine("You Draw");
                    }
                    else
                    {
                        loss++;
                        Console.WriteLine("You Lose");
                    }
                    Console.WriteLine($"Score: {win} wins, {loss} losses and {draw} draws");
                }

                else if (readKey == ConsoleKey.S)
                {
                    Console.WriteLine("You have picked Scissors");
                    if (game[0] == computerMove)
                    {
                        loss++;
                        Console.WriteLine("You Lose");
                    }
                    else if (game[1] == computerMove)
                    {
                        win++;
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        draw++;
                        Console.WriteLine("You Draw");
                    }
                    Console.WriteLine($"Score: {win} wins, {loss} losses and {draw} draws");
                }
                else if (readKey is ConsoleKey.Escape)
                {
                    return;
                }

                Console.WriteLine("Press any key to continue...");
                Console.WriteLine("Press Escape if you want to quit playing");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return;
                }
            }

            string randomMethod()
            {
                Random random = new Random();
                int index = random.Next(game.Length);
                Console.WriteLine($"The Computer Has Picked {game[index]}");
                return game[index];
            }
        }
    }
}
