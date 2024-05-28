// See https://aka.ms/new-console-template for more information

using _9._3_Introduce_Null_Object;

internal class Program
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