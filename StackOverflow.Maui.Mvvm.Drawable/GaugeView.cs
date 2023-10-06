namespace StackOverflow.Maui.Mvvm.Drawable;

public class GaugeView: GraphicsView, IDrawable
{
    public static readonly BindableProperty MinimumProperty
        = BindableProperty.Create(nameof(Minimum), typeof(double), typeof(GaugeView), 0.0, propertyChanged: RequestInvalidate);
    public static readonly BindableProperty MaximumProperty
        = BindableProperty.Create(nameof(Maximum), typeof(double), typeof(GaugeView), 100.0, propertyChanged: RequestInvalidate);
    public static readonly BindableProperty ValueProperty
        = BindableProperty.Create(nameof(Value), typeof(double), typeof(GaugeView), propertyChanged: RequestInvalidate);
    public static readonly BindableProperty GaugeColorProperty
        = BindableProperty.Create(nameof(GaugeColor), typeof(Color), typeof(GaugeView), Colors.SteelBlue, propertyChanged: RequestInvalidate);
    public static readonly BindableProperty GaugeSizeProperty
        = BindableProperty.Create(nameof(GaugeSize), typeof(float), typeof(GaugeView), 10.0f, propertyChanged: RequestInvalidate);
    public double Minimum
    {
        get => (double)GetValue(MinimumProperty);
        set => SetValue(MinimumProperty, value);
    }
    public double Maximum
    {
        get => (double)GetValue(MaximumProperty);
        set => SetValue(MaximumProperty, value);
    }
    public double Value
    {
        get => (double)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
    public Color GaugeColor
    {
        get => (Color)GetValue(GaugeColorProperty);
        set => SetValue(GaugeColorProperty, value);
    }
    public float GaugeSize
    {
        get => (float)GetValue(GaugeSizeProperty);
        set => SetValue(GaugeSizeProperty, value);
    }
    private static void RequestInvalidate(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is GaugeView)
        {
            ((GaugeView)bindable).Invalidate();
        }
    }

    public GaugeView()
    {
        Drawable = this;
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        double NormalizedValue = (Math.Clamp(Value, Minimum, Maximum) - Minimum) / (Maximum - Minimum);
        canvas.StrokeColor = GaugeColor;
        canvas.StrokeSize = GaugeSize;
        canvas.DrawArc(10f, 10f, (float)Width - 20f, (float)Height - 20f, 240f, 240f - (float) NormalizedValue * 300f, true, false);
    }
}
