namespace StatePattern
{
    public interface State
    {
        void Handle(Context context);
    }
}