using System;

namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GuessGame guessGame = new GuessGame(); 
           guessGame.Start();
        }
    }
}
