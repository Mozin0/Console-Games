using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    public class Menu
    {
        private string[] Options;
        private int SelectedIndex;
        private string Prompt;
        private string[] Description;

        public Menu(string prompt, string[] options, string[] description)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
            Description = description;
        }

        private void DisplayOptions()
        {
            Console.WriteLine(Prompt);

            for(int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string PrefixL;
                string PrefixR;
                string currentDescription;

                if (i == SelectedIndex)
                {
                    PrefixL = "<<";
                    PrefixR = ">>";
                    currentDescription = Description[i];
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    PrefixL = " ";
                    PrefixR = " ";
                    currentDescription = " ";

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;  
                }
                Console.WriteLine($"{PrefixL} {currentOption} {PrefixR}  {currentDescription}");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {             
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex < 0)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                } 
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
