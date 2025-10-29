namespace CoffeeMachine
{
    public class Chocolate : CondimentComponent
    {
        public Chocolate(CoffeeIF inner) : base(inner, 1.00) { }

        public override string GetCoffeeTypeName()
            => $"{GetInner()?.GetCoffeeTypeName()} + Chocolate";
    }
}
