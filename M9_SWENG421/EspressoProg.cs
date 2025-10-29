using System;

namespace CoffeeMachine
{
    public class EspressoProg : ProgramIF
    {
        public string ProgramName => "Espresso";

        public void run(CMM cmm)
        {
            cmm.setLEDNumber(3);
            Console.WriteLine("Machine status: RUNNING (Espresso)");

            cmm.setGrindingTime(5);
            cmm.setTemperature(200);

            CoffeeIF drink = new EspressoCoffee();
            drink = new Cream(drink);
            drink = new Vanilla(drink);
            drink = new Chocolate(drink);
            drink = new Chocolate(drink);
            cmm.setCoffee(drink);

            cmm.setLEDNumber(-1);
            Console.WriteLine("Machine status: IDLE");

            double p = cmm.computePrice();
            Console.WriteLine($"{drink.GetCoffeeTypeName()} => Sale Price = ${p:0.00}");
        }
    }
}
