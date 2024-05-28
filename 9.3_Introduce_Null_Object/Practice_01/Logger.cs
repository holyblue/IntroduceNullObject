namespace _9._3_Introduce_Null_Object.Practice_01;

// Original Logger class
public class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }

    public virtual void Error(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
}

// Service class