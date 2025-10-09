// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO74319669;

/// <summary>
/// 
/// </summary>
[ContentProperty(nameof(Value))]
[RequireService([typeof(IReferenceProvider), typeof(IProvideValueTarget)])]
public partial class DpiScaleExtension : BindableObject, IMarkupExtension<BindingBase>
{
	/// <summary>
	/// 
	/// </summary>
	[BindableProperty, NotifyPropertyChangedFor(nameof(Result))]
	public partial double Value { get; set; } = 1.0;

	/// <summary>
	/// 
	/// </summary>
	public double Scale => DeviceDisplay.MainDisplayInfo.Density;

	/// <summary>
	/// 
	/// </summary>
	public double Result => Value * Scale;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="serviceProvider"></param>
	/// <returns></returns>
	public object ProvideValue(IServiceProvider serviceProvider)
		=> (this as IMarkupExtension<BindingBase>).ProvideValue(serviceProvider);
	BindingBase IMarkupExtension<BindingBase>.ProvideValue(IServiceProvider serviceProvider)
	{
		if (serviceProvider.GetService(typeof(IProvideValueTarget)) is IProvideValueTarget provideValueTarget && provideValueTarget.TargetObject is BindableObject targetObject)
		{
			this.SetBinding(BindableObject.BindingContextProperty, static (BindableObject t) => t.BindingContext, BindingMode.OneWay, source: targetObject);
		}
		return BindingBase.Create(static (RgbColorExtension t) => t.Result, BindingMode.OneWay, source: this);
	}
}
