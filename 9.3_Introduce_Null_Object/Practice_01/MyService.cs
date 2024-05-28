namespace _9._3_Introduce_Null_Object.Practice_01;

public class MyService
{
    private readonly Logger _logger;

    public MyService(Logger logger)
    {
        _logger = logger;
    }

    public void DoSomething()
    {
        // Check for null logger
        if (_logger != null)
        {
            _logger.Log("Doing something...");
            // ...
        }
    }
}