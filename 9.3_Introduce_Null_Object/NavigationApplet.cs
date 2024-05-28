namespace _9._3_Introduce_Null_Object;

public class NavigationApplet : IApplet
{
    private MouseEventHandler _mouseEventHandler;

    public void SetMouseEventHandler(MouseEventHandler handler)
    {
        this._mouseEventHandler = handler;
    }
    
    public bool MouseMove(int x, int y)
    {
        if (_mouseEventHandler != null)
        {
            return _mouseEventHandler.Move(x, y);
        }

        return true;
    }

    public bool MouseDown(int x, int y)
    {
        if (_mouseEventHandler != null)
        {
            return _mouseEventHandler.Down(x, y);
        }

        return true;
    }

    public bool MouseUp(int x, int y)
    {
        if (_mouseEventHandler != null)
        {
            return _mouseEventHandler.Up(x, y);
        }
        
        return true;
    }

    public bool MouseExit(int x, int y)
    {
        if (_mouseEventHandler != null)
        {
            return _mouseEventHandler.Exit(x, y);
        }
        
        return true;
    }
}