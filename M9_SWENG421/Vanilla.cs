namespace CoffeeMachine
{
    public class Vanilla : CondimentComponent
    {
        public Vanilla(CoffeeIF inner) : base(inner, 0.50) { }

        public override string GetCoffeeTypeName()
            => $"{GetInner()?.GetCoffeeTypeName()} + Vanilla";
    }
}
