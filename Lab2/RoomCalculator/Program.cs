using System;

namespace RoomCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");    //into
            bool isCalculating = true; //exit condition
            do {
                // prompt the user for input
                Console.Write("Enter Length:");
                double l = int.Parse(Console.ReadLine());
                Console.Write("Enter Width:");
                double w = int.Parse(Console.ReadLine());
                Console.Write("Enter Height:");
                double h = int.Parse(Console.ReadLine());

                // calculate values and output results
                Console.WriteLine("Area:" + l * w);
                Console.WriteLine("Perimeter:" + (2 * l + 2 * w));
                Console.WriteLine("Volume:" + l * w * h);

                // ask user to go again
                Console.WriteLine("\nContinue(y/n)");
                string answer = Console.ReadLine();
                if(!(string.Equals(answer,"y")))
                    isCalculating = false; 
            } while (isCalculating);
        }
    }
}
