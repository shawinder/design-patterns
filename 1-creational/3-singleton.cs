/// <summary>
/// Eager initialization
/// </summary>
public sealed class Singleton
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
public sealed class Singleton
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
public sealed class Singleton
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

/// <summary>
/// .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. 
/// All you need to do is pass a delegate to the constructor which calls the Singleton constructor 
/// Implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode
/// </summary>
public sealed class Singleton
{
    private Singleton() { }
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
    public static Singleton Instance
    {
        get
        {
            return lazy.Value;
        }
    }
}