using System;

namespace CoffeeMachine
{
    public class CappuccinoProg : ProgramIF
    {
        public string ProgramName => "Cappuccino";

        public void run(CMM cmm)
        {
            cmm.setLEDNumber(2);
            Console.WriteLine("Machine status: RUNNING (Cappuccino)");

            cmm.setGrindingTime(7);
            cmm.setTemperature(145);

            CoffeeIF drink = new CappuccinoCoffee();
            cmm.setCoffee(drink);

            cmm.setLEDNumber(-1);
            Console.WriteLine("Machine status: IDLE");

            double p = cmm.computePrice();
            Console.WriteLine($"{drink.GetCoffeeTypeName()} => Sale Price = ${p:0.00}");
        }
    }
}
