using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Wpf;

namespace LifeLib.Wpf;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        
        OpenTkControl.Start(new GLWpfControlSettings
        {
            MajorVersion = 3,
            MinorVersion = 3
        });
    }

    private void OpenTkControl_OnRender(TimeSpan obj)
    {
        GL.ClearColor(Color4.Blue);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    }
}