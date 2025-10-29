namespace CoffeeMachine
{
    public abstract class CondimentComponent : CondimentIF
    {
        private readonly double basePrice; // shared private base price attribute for condiments
        private readonly CoffeeIF inner;

        protected CondimentComponent(CoffeeIF inner, double basePrice)
        {
            this.inner = inner;
            this.basePrice = basePrice;
        }

        public CoffeeIF GetInner() => inner;
        public double PriceContribution() => basePrice;

        public abstract string GetCoffeeTypeName(); // for display: forward inner name with condiment tag
    }
}
