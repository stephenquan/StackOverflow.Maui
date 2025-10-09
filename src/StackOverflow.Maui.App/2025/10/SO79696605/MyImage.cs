// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System.Windows.Input;
using CommunityToolkit.Maui.Behaviors;
using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79696605;

/// <summary>
/// A custom Image control that supports long-press gestures.
/// </summary>
public partial class MyImage : Image
{
	/// <summary>
	/// Gets or sets the command to invoke when the image is long-pressed.
	/// </summary>
	[BindableProperty] public partial ICommand? LongPressedCommand { get; set; }

	/// <summary>
	/// Gets or sets the command parameter to pass to the LongPressedCommand when the image is long-pressed.
	/// </summary>
	[BindableProperty] public partial object? LongPressedCommandParameter { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MyImage"/> class.
	/// </summary>
	public MyImage()
	{
		var behavior = new TouchBehavior();
		behavior.SetBinding(
			TouchBehavior.LongPressCommandProperty, static (MyImage i) => i.LongPressedCommand,
			BindingMode.OneWay,
			source: this);
		behavior.SetBinding(
			TouchBehavior.LongPressCommandParameterProperty, static (MyImage i) => i.LongPressedCommandParameter,
			BindingMode.OneWay,
			source: this);
		this.Behaviors.Add(behavior);
	}
}
