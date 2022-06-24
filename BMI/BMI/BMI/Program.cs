using System;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight;
            int height;
            int age;
            char m;
            char f;
            int BMI;

            Console.WriteLine("Caluclate Your BMI");
            Console.WriteLine("Enter your Details");
            Console.Write("Weight (Kg):");
            if (int.TryParse(Console.ReadLine(), out weight))
            {
                if (weight > 44 )
                {
                    
                }

            }
            Console.Write("Height (cm) :");
            if (int.TryParse(Console.ReadLine(), out height))
            {

            }
            //Console.Write("Age:");
            //do
            //{

            //    if (int.TryParse(Console.ReadLine(), out age))
            //    {
            //        if (age < 10)
            //        {
            //            Console.WriteLine("LOL");
            //            break;
            //        }
            //    }
            //    Console.Write("Gender (M or F):");
            //    Console.ReadLine();         

            //} while (true);
        }
    }
}
