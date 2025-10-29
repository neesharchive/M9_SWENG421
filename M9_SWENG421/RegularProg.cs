using System;

namespace CoffeeMachine
{
    public class RegularProg : ProgramIF
    {
        public string ProgramName => "Regular";

        public void run(CMM cmm)
        {
            cmm.setLEDNumber(0);
            Console.WriteLine("Machine status: RUNNING (Regular)");

            cmm.setGrindingTime(6);
            cmm.setTemperature(140);

            CoffeeIF drink = new RegularCoffee();
            cmm.setCoffee(drink);

            cmm.setLEDNumber(-1);
            Console.WriteLine("Machine status: IDLE");

            double p = cmm.computePrice();
            Console.WriteLine($"{drink.GetCoffeeTypeName()} => Sale Price = ${p:0.00}");
        }
    }
}
