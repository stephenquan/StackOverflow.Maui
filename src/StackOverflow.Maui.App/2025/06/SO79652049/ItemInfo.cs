// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;

namespace StackOverflow.Maui.App.SO79652049;

/// <summary>
/// Information about an item, including its name and selection status.
/// </summary>

public partial class ItemInfo : ObservableObject
{
	/// <summary>
	/// Gets or sets the name of the item.
	/// </summary>
	[ObservableProperty] public partial string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets a value indicating whether the item is selected.
	/// </summary>
	[ObservableProperty] public partial bool IsSelected { get; set; } = false;
}
