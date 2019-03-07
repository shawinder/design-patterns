public abstract class Subject
{
    private ArrayList observers = new ArrayList();

    public void Attach(IObserver o)
    {
        observers.Add(o);
    }

    public void Detach(IObserver o)
    {
        observers.Remove(o);
    }

    public void Notify()
    {
        foreach (IObserver o in observers)
        {
            o.Update();
        }
    }
}

public class ConcreteSubject : Subject
{
    private string state;

    public string GetState()
    {
        return state;
    }

    public void SetState(string newState)
    {
        state = newState;
        Notify();
    }
}

public interface IObserver
{
    void Update();
}

public class ConcreteObserver : IObserver
{
    private ConcreteSubject subject;

    public ConcreteObserver(ConcreteSubject sub)
    {
        subject = sub;
    }

    public void Update()
    {
        string subjectState = subject.GetState();
        Console.WriteLine(subjectState);
    }
}