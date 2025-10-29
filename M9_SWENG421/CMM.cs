using System;
using System.Reflection;

namespace CoffeeMachine
{
    public class CMM
    {
        private CoffeeIF cif;  // private instance var
        public ProgramIF rp;   // RegularProg
        public ProgramIF mp;   // MochaProg
        public ProgramIF cp;   // CappuccinoProg

        public CMM()
        {
            rp = new RegularProg();
            mp = new MochaProg();
            cp = new CappuccinoProg();
        }

        // 6 public functions:
        public void runCoffeeProgram(string programName)
        {
            if (string.Equals(programName, "Regular", StringComparison.OrdinalIgnoreCase)) { rp.run(this); return; }
            if (string.Equals(programName, "Mocha", StringComparison.OrdinalIgnoreCase)) { mp.run(this); return; }
            if (string.Equals(programName, "Cappuccino", StringComparison.OrdinalIgnoreCase)) { cp.run(this); return; }

            string fqcn = $"CoffeeMachine.{programName}Prog";
            var t = Type.GetType(fqcn, throwOnError: false);
            if (t != null && typeof(ProgramIF).IsAssignableFrom(t))
            {
                var prog = (ProgramIF?)Activator.CreateInstance(t);
                prog?.run(this);
                return;
            }

            Console.WriteLine($"Program '{programName}' not found.");
        }

        public void setGrindingTime(int secs)
        {
            Console.WriteLine($"Grinding for {secs} seconds.");
        }

        public void setTemperature(int degree)
        {
            Console.WriteLine($"Heating water to {degree}°F.");
        }

        public void setLEDNumber(int num)
        {
            if (num == -1)
            {
                Console.WriteLine("LED: IDLE");
                return;
            }
            Console.WriteLine($"LED: {num}");
        }

        public void setCoffee(CoffeeIF cif)
        {
            this.cif = cif;
            Console.WriteLine($"Selected: {cif.GetCoffeeTypeName()}");
        }

        public double computePrice()
        {
            double sum = 0.0;
            CoffeeIF cur = cif;
            while (cur != null)
            {
                sum += cur.PriceContribution();
                cur = cur.GetInner();
            }
            return sum;
        }
    }
}
