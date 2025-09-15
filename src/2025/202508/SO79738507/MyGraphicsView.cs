using SQuan.Helpers.Maui.Mvvm;

namespace SO79738507;

/// <summary>
/// Custom graphics view that implements IDrawable to draw a line graph based on float data.
/// </summary>
public partial class MyGraphicsView : GraphicsView, IDrawable
{
	/// <summary>
	/// Gets or sets the array of floating-point values associated with the data.
	/// </summary>
	[BindableProperty]
	public partial float[]? Data { get; set; }

	/// <summary>
	/// Gets or sets the color used for stroking lines in the graphics view.
	/// </summary>
	[BindableProperty]
	public partial Color StrokeColor { get; set; } = Colors.Red;

	/// <summary>
	/// Initializes a new instance of the <see cref="MyGraphicsView"/> class.
	/// </summary>
	public MyGraphicsView()
	{
		Drawable = this;
		PropertyChanged += (s, e) =>
		{
			switch (e.PropertyName)
			{
				case nameof(Data):
				case nameof(StrokeColor):
					Invalidate();
					break;
			}
		};
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
				canvas.DrawLine(
					(float)(i * this.Width / Data.Length),
					(float)(Data[i] * this.Height),
					(float)((i + 1) * this.Width / Data.Length),
					(float)(Data[i + 1] * this.Height));
			}
		}
	}
}
