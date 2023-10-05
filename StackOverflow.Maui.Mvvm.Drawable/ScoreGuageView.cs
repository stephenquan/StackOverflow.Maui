namespace StackOverflow.Maui.Mvvm.Drawable;

public class ScoreGuageView : GraphicsView, IDrawable
{
    public static readonly BindableProperty ScoreProperty
        = BindableProperty.Create(nameof(Score), typeof(float), typeof(ScoreGuageView), propertyChanged: ScorePropertyChanged);

    public float Score
    {
        get => (float)GetValue(ScoreProperty);
        set => SetValue(ScoreProperty, value);
    }

    private static void ScorePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ScoreGuageView)
        {
            ((ScoreGuageView)bindable).Invalidate();
        }
    }

    public ScoreGuageView()
    {
        Drawable = this;
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.SteelBlue;
        canvas.StrokeSize = 10.0f;
        canvas.DrawArc(10, 10, (float)Width - 20f, (float)Height - 20f, 240, 240 - Score * 300 / 100, true, false);
    }
}
