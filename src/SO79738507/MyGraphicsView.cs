namespace SO79738507;

/// <summary>
/// Custom graphics view that implements IDrawable to draw a line graph based on float data.
/// </summary>
public partial class MyGraphicsView : GraphicsView, IDrawable
{
	/// <summary>
	/// Identifies the bindable property for the <see cref="Data"/> property.
	/// </summary>
	public static readonly BindableProperty DataProperty =
		BindableProperty.Create(nameof(Data), typeof(float[]), typeof(MyGraphicsView),
			propertyChanged: (b, o, n) => ((MyGraphicsView)(b)).Invalidate());

	/// <summary>
	/// Gets or sets the array of floating-point values associated with the data.
	/// </summary>
	public float[]? Data
	{
		get => (float[]?)GetValue(DataProperty);
		set => SetValue(DataProperty, value);
	}

	/// <summary>
	/// Identifies the bindable property for the stroke color of the graphics view.
	/// </summary>
	public static readonly BindableProperty StrokeColorProperty =
		BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(MyGraphicsView), Colors.Red,
			propertyChanged: (b, o, n) => ((MyGraphicsView)(b)).Invalidate());

	/// <summary>
	/// Gets or sets the color used for stroking lines in the graphics view.
	/// </summary>
	public Color StrokeColor
	{
		get => (Color)GetValue(StrokeColorProperty);
		set => SetValue(StrokeColorProperty, value);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MyGraphicsView"/> class.
	/// </summary>
	public MyGraphicsView()
	{
		Drawable = this;
	}

	/// <summary>
	/// Renders a series of connected lines on the specified canvas based on the provided data points.
	/// </summary>
	/// <param name="canvas">The canvas on which the lines will be drawn. Cannot be <see langword="null"/>.</param>
	/// <param name="dirtyRect">The rectangular area of the canvas that needs to be redrawn. This parameter is currently unused but may be relevant
	/// in future implementations.</param>
	public void Draw(ICanvas canvas, RectF dirtyRect)
	{
		canvas.StrokeColor = this.StrokeColor;
		if (Data is not null && Data.Length > 0)
		{
			for (int i = 0; i < Data.Length - 1; i++)
			{
				canvas.DrawLine(5 * i, 100 * Data[i], 5 * (i + 1), 100 * Data[i + 1]);
			}
		}
	}
}
