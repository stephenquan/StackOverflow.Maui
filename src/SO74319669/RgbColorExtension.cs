using SQuan.Helpers.Maui.Mvvm;

namespace SO74319669;

/// <summary>Provides a markup extension for creating a color binding based on RGB values.</summary>
[ContentProperty(nameof(R))]
[AcceptEmptyServiceProvider]
public partial class RgbColorExtension : BindableObject, IMarkupExtension<BindingBase>
{
	/// <summary>Gets or sets the red component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Color))] public partial float R { get; set; } = 0.0f;
	/// <summary>Gets or sets the green component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Color))] public partial float G { get; set; } = 0.0f;
	/// <summary>Gets or sets the blue component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Color))] public partial float B { get; set; } = 0.0f;
	/// <summary>Gets or sets the alpha component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Color))] public partial float A { get; set; } = 0.0f;
	/// <summary>Gets the color represented by the current RGBA values.</summary>
	public Color Color => Color.FromRgba(R, G, B, A);
	/// <summary>Returns a binding that provides the color based on the current RGBA values.</summary>
	/// <param name="serviceProvider"></param>
	/// <returns></returns>
	public object ProvideValue(IServiceProvider serviceProvider) => (this as IMarkupExtension<BindingBase>).ProvideValue(serviceProvider);
	BindingBase IMarkupExtension<BindingBase>.ProvideValue(IServiceProvider serviceProvider) => BindingBase.Create(static (RgbColorExtension t) => t.Color, BindingMode.OneWay, source: this);
}
