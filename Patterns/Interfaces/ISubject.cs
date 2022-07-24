namespace Patterns
{
    public interface ISubject
    {
        void registerObserver(IObserverr o);
        void removeObserver(IObserverr o);
        void notifyObserver();

    }
}
