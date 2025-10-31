// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLite;

namespace StackOverflow.Maui.App.SO72692504;



/// <summary>
/// ViewModel for SQLite with MVVM in .NET MAUI.
/// </summary>
public partial class MainViewModel : ObservableObject
{
	string dbPath { get; } = Path.Combine(FileSystem.AppDataDirectory, "friends.sqlite");
	SQLiteConnection db { get; }

	/// <summary>
	/// Gets or sets the new friend's name.
	/// </summary>
	[ObservableProperty]
	public partial string NewFriendName { get; set; } = string.Empty;

	partial void OnNewFriendNameChanged(string value) => AddFriendCommand.NotifyCanExecuteChanged();

	/// <summary>
	/// Gets the list of friends from the database.
	/// </summary>
	public List<Friend> Friends => db.Table<Friend>().ToList();

	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	public MainViewModel()
	{
		db = new SQLiteConnection(dbPath);
		db.CreateTable<Friend>();
	}

	bool CanAddFriend() => !string.IsNullOrWhiteSpace(NewFriendName);

	/// <summary>
	/// Adds a new friend to the database and updates the Friends property.
	/// </summary>
	[RelayCommand(CanExecute = nameof(CanAddFriend))]
	public void AddFriend()
	{
		if (string.IsNullOrWhiteSpace(NewFriendName))
		{
			return;
		}

		db.Insert(new Friend { Name = NewFriendName });
		OnPropertyChanged(nameof(Friends));
	}

	/// <summary>
	/// Clears all friends from the database and updates the Friends property.
	/// </summary>
	[RelayCommand]
	public void ClearFriends()
	{
		db.DeleteAll<Friend>();
		OnPropertyChanged(nameof(Friends));
	}
}
