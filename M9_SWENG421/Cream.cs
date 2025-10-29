namespace CoffeeMachine
{
    public class Cream : CondimentComponent
    {
        public Cream(CoffeeIF inner) : base(inner, 0.25) { }

        public override string GetCoffeeTypeName()
            => $"{GetInner()?.GetCoffeeTypeName()} + Cream";
    }
}
