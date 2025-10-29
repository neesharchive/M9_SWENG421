namespace CoffeeMachine
{
    public interface CoffeeIF
    {
        // For decorator traversal
        CoffeeIF GetInner();

        // Description for display
        string GetCoffeeTypeName();

        // Price contribution of this node (coffee or condiment)
        double PriceContribution();
    }
}
