// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using Microsoft.Maui.Controls.Shapes;

namespace StackOverflow.Maui.App.SO79772080;

/// <summary>
/// Represents an image with automatic clipping based on its scale.
/// </summary>
public partial class MyImage : Image
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MyImage"/> class.
	/// </summary>
	public MyImage()
	{
		PropertyChanged += (s, e) =>
		{
			switch (e.PropertyName)
			{
				case nameof(VisualElement.Width):
				case nameof(VisualElement.Height):
				case nameof(Image.Scale):
					if (Scale > 1.0)
					{
						double clipWidth = Width / Scale;
						double clipHeight = Height / Scale;
						Clip = new RectangleGeometry
						{
							Rect = new Rect((Width - clipWidth) / 2, (Height - clipHeight) / 2, clipWidth, clipHeight)
						};
					}
					else
					{
						Clip = null;
					}
					break;
			}
		};
	}
}
