using System;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmm = new CMM();

            Console.WriteLine("=== Cup #1: Mocha + Cream + Vanilla ===");
            cmm.runCoffeeProgram("Mocha");

            Console.WriteLine();
            Console.WriteLine("=== Cup #2: Espresso + Cream + Vanilla + Double Chocolate ===");
            cmm.runCoffeeProgram("Espresso");

            Console.WriteLine();
            Console.WriteLine("Done.");
        }
    }
}
