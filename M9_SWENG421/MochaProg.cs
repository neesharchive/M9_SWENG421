using System;

namespace CoffeeMachine
{
    public class MochaProg : ProgramIF
    {
        public string ProgramName => "Mocha";

        public void run(CMM cmm)
        {
            cmm.setLEDNumber(1);
            Console.WriteLine("Machine status: RUNNING (Mocha)");

            cmm.setGrindingTime(8);
            cmm.setTemperature(150);

            CoffeeIF drink = new MochaCoffee();
            drink = new Cream(drink);
            drink = new Vanilla(drink);
            cmm.setCoffee(drink);

            cmm.setLEDNumber(-1);
            Console.WriteLine("Machine status: IDLE");

            double p = cmm.computePrice();
            Console.WriteLine($"{drink.GetCoffeeTypeName()} => Sale Price = ${p:0.00}");
        }
    }
}
