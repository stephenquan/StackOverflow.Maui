// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO74319669;

/// <summary>Provides a markup extension for creating a color binding based on RGB values.</summary>
[ContentProperty(nameof(R))]
[RequireService([typeof(IReferenceProvider), typeof(IProvideValueTarget)])]
public partial class RgbColorExtension : BindableObject, IMarkupExtension<BindingBase>
{
	/// <summary>Gets or sets the red component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial float R { get; set; } = 0.0f;
	/// <summary>Gets or sets the green component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial float G { get; set; } = 0.0f;
	/// <summary>Gets or sets the blue component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial float B { get; set; } = 0.0f;
	/// <summary>Gets or sets the alpha component of the color.</summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial float A { get; set; } = 0.0f;
	/// <summary>Gets the color represented by the current RGBA values.</summary>
	public Color Result => Color.FromRgba(R, G, B, A);
	/// <summary>Returns a binding that provides the color based on the current RGBA values.</summary>
	/// <param name="serviceProvider"></param>
	/// <returns></returns>
	public object ProvideValue(IServiceProvider serviceProvider) => (this as IMarkupExtension<BindingBase>).ProvideValue(serviceProvider);

	BindingBase IMarkupExtension<BindingBase>.ProvideValue(IServiceProvider serviceProvider)
	{
		if (serviceProvider.GetService(typeof(IProvideValueTarget)) is IProvideValueTarget provideValueTarget && provideValueTarget.TargetObject is BindableObject targetObject)
		{
			this.SetBinding(BindableObject.BindingContextProperty, static (BindableObject t) => t.BindingContext, BindingMode.OneWay, source: targetObject);
		}
		return BindingBase.Create(static (RgbColorExtension t) => t.Result, BindingMode.OneWay, source: this);
	}
}
