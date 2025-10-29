namespace CoffeeMachine
{
    public abstract class CoffeeComponent : CoffeeIF
    {
        // "shared private base price attribute" (shared through inheritance, private to this class)
        private readonly double basePrice;

        protected CoffeeComponent(double basePrice)
        {
            this.basePrice = basePrice;
        }

        public CoffeeIF GetInner() => null;
        public double PriceContribution() => basePrice;

        public abstract string GetCoffeeTypeName();
    }
}
