using System.Numerics;

namespace Engine;

public abstract class ViewDriver
{
    public double Width { get; private set; }
    public double Height { get; private set; }
    
    public abstract void AfterRender();
    public abstract void PostRender();
    
    public abstract void DrawCircle(Vector3 pos, double r, Vector3 color);
    public abstract void DrawRect(Vector3 pos, double r, Vector3 color);
    public abstract void DrawLine(Vector3 p1, Vector3 p2, Vector3 color);

    public virtual void Resize(int width, int height)
    {
        Width = width;
        Height = height;
    }
}