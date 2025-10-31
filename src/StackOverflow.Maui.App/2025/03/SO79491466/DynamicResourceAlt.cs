// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79491466;

/// <summary>
/// Implements a DynamicResource alternative as a Markup Extension so that it works with Behaviors.
/// </summary>
[ContentProperty(nameof(Key))]
[RequireService([typeof(IReferenceProvider), typeof(IProvideValueTarget)])]
public partial class DynamicResourceAlt : Button, IMarkupExtension<BindingBase>
{
	/// <summary>
	/// Gets or sets the resource key.
	/// </summary>
	[BindableProperty] public partial string Key { get; set; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="DynamicResourceAlt"/> class.
	/// </summary>
	public DynamicResourceAlt()
	{
		this.Parent = Application.Current;
		this.PropertyChanged += (s, e) =>
		{
			if (e.PropertyName == nameof(Key) && !string.IsNullOrEmpty(Key))
			{
				SetDynamicResource(Button.CommandParameterProperty, Key);
			}
		};
	}

	/// <summary>
	/// Provides the value of the markup extension for the target property.
	/// </summary>
	/// <remarks>This method is used in XAML processing to provide the value of the markup extension.
	/// It is typically called by the XAML processor and not directly by user code.</remarks>
	/// <param name="serviceProvider">An object that can provide services for the markup extension.
	/// This is typically used to obtain context information about the environment in which the markup extension is being used.</param>
	/// <returns>The object to be set on the property where the extension is applied.
	/// This is typically a <see cref="BindingBase"/> object.</returns>
	public object ProvideValue(IServiceProvider serviceProvider)
		=> (this as IMarkupExtension<BindingBase>).ProvideValue(serviceProvider);

	/// <summary>
	/// Provides the value of the markup extension for the target property.
	/// </summary>
	/// <param name="serviceProvider">An object that can provide services for the markup extension.
	/// This is typically used to obtain context information about the environment in which the markup extension is being used.</param>
	/// <returns>The object to be set on the property where the extension is applied.
	/// This is typically a <see cref="BindingBase"/> object.</returns>
	BindingBase IMarkupExtension<BindingBase>.ProvideValue(IServiceProvider serviceProvider)
	{
		// Implement a BindingContext inheritance so that the Key can be readily bound from a view model.
		if (serviceProvider.GetService(typeof(IProvideValueTarget)) is IProvideValueTarget provideValueTarget && provideValueTarget.TargetObject is BindableObject targetObject)
		{
			this.SetBinding(BindingContextProperty, static (BindableObject t) => t.BindingContext, BindingMode.OneWay, source: targetObject);
		}

		// Return a Binding to the CommandParameter property which has the DynamicResource set on it.
		return BindingBase.Create(static (DynamicResourceAlt t) => t.CommandParameter, BindingMode.OneWay, source: this);
	}
}
