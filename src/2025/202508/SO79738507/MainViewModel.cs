﻿namespace SO79738507;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

#if ORIGINAL_MAINVIEWMODEL
/// <summary>
/// Represents the main view model for the application, providing data and commands for the user interface.
/// </summary>
public partial class MainViewModel : ObservableObject
{
	/// <summary>
	/// Gets an array of floating-point numbers used to hold data.
	/// </summary>
	[ObservableProperty]
	public partial float[]? DataHolder { get; set; }

	static Random rand = new Random();

	/// <summary>
	/// Refreshes the data by generating a new set of random floating-point values.
	/// </summary>
	[RelayCommand]
	public void Refresh()
	{
		/*
		float[] temp = new float[100];
		for (int i = 0; i < 100; i++)
		{
			temp[i] = rand.NextSingle();
		}
		DataHolder = temp;
		*/
		DataHolder = Enumerable.Range(0, 100).Select(i => rand.NextSingle()).ToArray();
	}
}
#endif

/// <summary>
/// Implements the main view model for the application, providing data and commands for the user interface.
/// </summary>
public partial class MainViewModel : ObservableObject
{
	static Random rand = new Random();
	/// <summary>
	/// Gets an array of randomly generated single-precision floating-point numbers.
	/// </summary>
	public float[]? DataHolder => Enumerable.Range(0, 100).Select(i => rand.NextSingle()).ToArray();

	/// <summary>
	/// Refreshes the data by generating a new set of random floating-point values.
	/// </summary>
	[RelayCommand]
	public void Refresh() => OnPropertyChanged(nameof(DataHolder));
}
