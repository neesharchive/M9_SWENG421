namespace CoffeeMachine
{
    public interface ProgramIF
    {
        void run(CMM cmm);
        string ProgramName { get; }
    }
}
