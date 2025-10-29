namespace CoffeeMachine
{
    public class EspressoCoffee : CoffeeComponent
    {
        public EspressoCoffee() : base(5.0) { }
        public override string GetCoffeeTypeName() => "Espresso";
    }
}
