// See https://aka.ms/new-console-template for more information

namespace _9._3_Introduce_Null_Object;

internal static class Program
{
    public static void Main(string[] args)
    {
        var navigationApplet = new NavigationApplet();
        navigationApplet.SetMouseEventHandler(new MouseEventHandler());
        navigationApplet.MouseMove(1, 3);
        navigationApplet.MouseUp(2, 5);
        navigationApplet.MouseDown(3, 0);
        navigationApplet.MouseExit(0, 0);
    }
}