// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.Input;

namespace StackOverflow.Maui.App.SO79696605;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Gets a list of photos to display in the collection view.
	/// </summary>
	public List<PhotoItemViewModel> Photos { get; } =
	[
		new PhotoItemViewModel { PhotoName = "Photo 1" },
		new PhotoItemViewModel { PhotoName = "Photo 2" },
		new PhotoItemViewModel { PhotoName = "Photo 3" },
		new PhotoItemViewModel { PhotoName = "Photo 4" },
		new PhotoItemViewModel { PhotoName = "Photo 5" },
		new PhotoItemViewModel { PhotoName = "Photo 6" },
		new PhotoItemViewModel { PhotoName = "Photo 7" },
		new PhotoItemViewModel { PhotoName = "Photo 8" },
		new PhotoItemViewModel { PhotoName = "Photo 9" },
		new PhotoItemViewModel { PhotoName = "Photo 10" },
	];

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>
	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}

	[RelayCommand]
	async Task ImageLongPressed(PhotoItemViewModel photo)
	{
		await DisplayAlert("Long Pressed", photo.PhotoName, "OK");
	}
}
