namespace StatePattern
{
    public class ConcreteStateC : State
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateA();
            System.Console.WriteLine("Handling in ConcreteStateC");
        }
    }
}