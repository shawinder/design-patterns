public interface Subject
{
    void PerformAction();
}

public class RealSubject : Subject
{
    public void PerformAction()
    {
        Console.WriteLine("RealSubject action performed.");
    }
}

public class Proxy : Subject
{
    private RealSubject _realSubject;

    public void PerformAction()
    {
        if (_realSubject == null)
            _realSubject = new RealSubject();

        _realSubject.PerformAction();
    }
}