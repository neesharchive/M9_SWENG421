namespace CoffeeMachine
{
    public class CappuccinoCoffee : CoffeeComponent
    {
        public CappuccinoCoffee() : base(3.0) { }
        public override string GetCoffeeTypeName() => "Cappuccino";
    }
}
