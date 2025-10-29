namespace CoffeeMachine
{
    public class MochaCoffee : CoffeeComponent
    {
        public MochaCoffee() : base(4.0) { }
        public override string GetCoffeeTypeName() => "Mocha";
    }
}
