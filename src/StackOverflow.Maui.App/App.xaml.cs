// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System.Globalization;
using CsvHelper;

namespace StackOverflow.Maui.App;

/// <summary>
/// Represents the main application class responsible for initializing and managing the application lifecycle.
/// </summary>
public partial class App : Application
{
	/// <summary>
	/// Gets the task that represents the asynchronous initialization process of the application.
	/// </summary>
	public Task InitializeTask { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="App"/> class.
	/// </summary>
	public App()
	{
		InitializeTask = InitializeAsync();
		InitializeComponent();
	}

	/// <summary>
	/// Creates a new instance of a <see cref="Window"/> with the specified activation state.
	/// </summary>
	/// <param name="activationState">The activation state used to initialize the window. Can be <see langword="null"/>.</param>
	/// <returns>A new <see cref="Window"/> instance initialized with an <see cref="AppShell"/>.</returns>
	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}

	async Task InitializeAsync()
	{
		var assembly = typeof(SampleCsv).Assembly;
		using var stream = await FileSystem.OpenAppPackageFileAsync("samples.csv");
		using var reader = new StreamReader(stream);
		using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
		await foreach (var record in csv.GetRecordsAsync<SampleCsv>())
		{
			if (record.Id is string id
				&& !string.IsNullOrEmpty(id)
				&& DateTime.Parse(record.Created) is DateTime created
				&& DateTime.Parse(record.Answered) is DateTime answered
				&& $"SO{record.Id}_MainPage" is string route
				&& assembly.GetType($"StackOverflow.Maui.App.SO{record.Id}.MainPage") is Type routeType
				&& record.Title is string title
				&& !string.IsNullOrEmpty(title)
				&& record.Description is string description
				&& !string.IsNullOrEmpty(description))
			{
				AppViewModel.Current.RegisterSample(id, created, answered, route, routeType, title, description);
			}
		}
	}
}
