using System;

namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Guess a number between 1-100");
                Random random = new();
                var guessNumber = random.Next(1, 100);

                int result;

                do
                {
                    if (!int.TryParse(Console.ReadLine(), out result) || result is < 1 or > 100)
                    {
                        Console.WriteLine("Pick a valid number between 1-100");
                        continue;
                    }
                    if (result == guessNumber)
                    {
                        Console.WriteLine("You have guessed the Correct Number, Well Done!");
                    }
                    else if (Math.Abs(guessNumber - result) <= 5)
                    {
                        Console.WriteLine("You are close");
                    }

                    else if (result > guessNumber)
                    {
                        Console.WriteLine("Thats too high");
                    }
                    else if (result < guessNumber)
                    {
                        Console.WriteLine("Thats too low");
                    }
                    
                } while (result != guessNumber);

                Console.WriteLine("Press any key to Play again...");
                Console.WriteLine("Press Escape if you want to quit playing");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
