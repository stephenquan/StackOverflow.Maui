// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;

namespace StackOverflow.Maui.App.SO79696605;

/// <summary>
/// Represents a view model for a photo item, containing properties related to the photo's display and metadata.
/// </summary>
public partial class PhotoItemViewModel : ObservableObject
{
	/// <summary>
	/// Gets or sets the name of the photo.
	/// </summary>
	[ObservableProperty]
	public partial string PhotoName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the source of the thumbnail image for the photo.
	/// </summary>
	[ObservableProperty]
	public partial string ThumbnailImageSource { get; set; } = "dotnet_bot.png";

	/// <summary>
	/// Gets or sets a value indicating whether the photo is selected.
	/// </summary>
	[ObservableProperty]
	public partial bool IsSelected { get; set; } = false;
}
