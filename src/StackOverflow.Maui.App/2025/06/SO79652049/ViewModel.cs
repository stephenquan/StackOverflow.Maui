// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace StackOverflow.Maui.App.SO79652049;

/// <summary>
/// ViewModel for managing a collection of user items and their selection state.
/// </summary>
public partial class ViewModel : ObservableObject
{
	/// <summary>
	/// Gets the collection of user items, each represented by an <see cref="ItemInfo"/> object.
	/// </summary>
	public ObservableCollection<ItemInfo> UserItems { get; } =
	[
		new ItemInfo { Name = "Player 31415" },
		new ItemInfo { Name = "Player 92653" },
		new ItemInfo { Name = "Player 58979" }
	];

	/// <summary>
	/// Gets a collection of user items sorted by their names in ascending order.
	/// </summary>
	public ObservableCollection<ItemInfo> SortedUserItems => new ObservableCollection<ItemInfo>(UserItems.OrderBy(item => item.Name));

	/// <summary>
	/// Gets or sets the currently selected item.
	/// </summary>
	[ObservableProperty] public partial ItemInfo? SelectedItem { get; set; } = null;

	/// <summary>
	/// Handles changes to the selected item by updating its selection state.
	/// </summary>
	partial void OnSelectedItemChanged(ItemInfo? oldValue, ItemInfo? newValue)
	{
		if (oldValue is not null) oldValue.IsSelected = false;
		if (newValue is not null) newValue.IsSelected = true;
	}

	Random random = new Random();

	/// <summary>
	/// Adds a new user item to the collection and triggers an update to the sorted user items.
	/// </summary>
	[RelayCommand]
	public void AddAndSort()
	{
		UserItems.Add(new ItemInfo { Name = $"Player {random.Next(0, 100000).ToString("D5")}" }); // Example of adding a new item
		OnPropertyChanged(nameof(SortedUserItems));
	}
}
