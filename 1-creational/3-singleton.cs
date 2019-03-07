/// <summary>
/// Eager initialization
/// </summary>
public class Singleton
{
    private static Singleton instance = new Singleton();
    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            return instance;
        }
    }
}

/// <summary>
/// Lazy initialization
/// </summary>
public class Singleton
{
    private static Singleton instance = null;
    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}

/// <summary>
/// Thread-safe (Double-checked Locking)
/// </summary>
public class Singleton
{
    private static Singleton instance = null;
    private Singleton() { }
    private static object lockThis = new object();

    public static Singleton GetInstance
    {
        get
        {
            lock (lockThis)
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}