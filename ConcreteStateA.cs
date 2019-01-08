namespace StatePattern
{
    public class ConcreteStateA : State
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
            System.Console.WriteLine("Handling in ConcreteStateA");
        }
    }
}