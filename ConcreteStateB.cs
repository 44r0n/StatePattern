namespace StatePattern
{
    public class ConcreteStateB : State
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateC();
            System.Console.WriteLine("Handling in ConcreteStateB");
        }
    }
}