// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO63922234;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

[ContentProperty(nameof(IconName))]
[RequireService([typeof(IReferenceProvider), typeof(IProvideValueTarget)])]
public partial class FontImageExtension : BindableObject, IMarkupExtension<BindingBase>
{
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial double Size { get; set; } = 30.0;
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial string IconName { get; set; } = string.Empty;
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial Color Color { get; set; } = Colors.Black;
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))] public partial string FontFamily { get; set; } = string.Empty;
	public FontImageSource? Result
		=> new FontImageSource
		{
			FontFamily = FontFamily,
			Glyph = IconName,
			Color = Color,
			Size = Size
		};
	public object ProvideValue(IServiceProvider serviceProvider) => (this as IMarkupExtension<BindingBase>).ProvideValue(serviceProvider);
	BindingBase IMarkupExtension<BindingBase>.ProvideValue(IServiceProvider serviceProvider)
	{
		if (serviceProvider.GetService(typeof(IProvideValueTarget)) is IProvideValueTarget provideValueTarget && provideValueTarget.TargetObject is BindableObject targetObject)
		{
			this.SetBinding(BindableObject.BindingContextProperty, static (BindableObject t) => t.BindingContext, BindingMode.OneWay, source: targetObject);
		}
		return BindingBase.Create(static (FontImageExtension t) => t.Result, BindingMode.OneWay, source: this);
	}
}
