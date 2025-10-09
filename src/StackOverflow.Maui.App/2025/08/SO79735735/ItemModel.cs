// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;

namespace StackOverflow.Maui.App.SO79735735;

/// <summary>
/// Simple model class that represents an item with a count.
/// </summary>
public partial class ItemModel : ObservableObject
{
	/// <summary>
	/// Gets or sets the name of the item.
	/// </summary>
	[ObservableProperty] public partial string Name { get; set; } = "Name";

	/// <summary>
	/// Gets or sets the second name of the item.
	/// </summary>
	[ObservableProperty] public partial string Name2 { get; set; } = "Name2";

	/// <summary>
	/// Gets or sets the count value.
	/// </summary>
	[ObservableProperty] public partial decimal Count { get; set; } = 0m;
}
