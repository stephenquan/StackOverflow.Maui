using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Maui.Mvvm.Drawable;

public class MainDrawable : IDrawable
{
    public MainViewModel VM { get; }

    public MainDrawable()
    {
        VM = ServiceHelper.GetService<MainViewModel>();
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = Colors.Red;
        canvas.FillRectangle(20.0f, 20.0f, VM.Score, VM.Score);
    }
}
