namespace _9._3_Introduce_Null_Object;

public class MouseEventHandler
{
    public bool Move(int x, int y)
    {
        // Do Move
        Console.WriteLine($"move to x:{x} y:{y}");
        return true;
    }

    public bool Down(int x, int y)
    {
        // Do Down
        Console.WriteLine($"down to x:{x} y:{y}");
        return true;
    }

    public bool Up(int x, int y)
    {
        // Do Up
        Console.WriteLine($"up to x:{x} y:{y}");
        return true;
    }

    public bool Exit(int x, int y)
    {
        // Do Exit
        Console.WriteLine($"exit to x:{x} y:{y}");
        return true;
    }
}