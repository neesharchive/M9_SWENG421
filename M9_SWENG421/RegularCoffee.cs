namespace CoffeeMachine
{
    public class RegularCoffee : CoffeeComponent
    {
        public RegularCoffee() : base(2.0) { }
        public override string GetCoffeeTypeName() => "Regular";
    }
}
