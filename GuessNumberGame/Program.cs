using System;

namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-100");
            Random random = new();
            var guessNumber = random.Next(1,100);
            Console.WriteLine(guessNumber);

            int result;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out result) || result is < 1 or > 100)
                {
                    Console.WriteLine("Pick a valid number between 1-100");
                    continue;
                }
                if (Math.Abs(guessNumber - result) <= 5)
                {
                    Console.WriteLine("You are close"); 
                    if (result == guessNumber)
                    {
                        Console.WriteLine("You have guessed the Correct Number, Well Done!");
                    }
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
        }
    }
}
