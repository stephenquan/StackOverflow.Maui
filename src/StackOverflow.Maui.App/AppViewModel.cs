using CommunityToolkit.Mvvm.ComponentModel;

namespace StackOverflow.Maui.App;

/// <summary>
/// The singleton view model for the entire application.
/// </summary>
public partial class AppViewModel : ObservableObject
{
	/// <summary>
	/// Gets the current instance of the <see cref="AppViewModel"/>.
	/// </summary>
	public static AppViewModel Current { get; } = new AppViewModel();

	/// <summary>
	/// Gets or sets the sample the user is currently viewing.
	/// </summary>
	[ObservableProperty]
	public partial Sample? SelectedSample { get; set; }

	/// <summary>
	/// Gets the list of samples.
	/// </summary>
	public List<Sample> Samples { get; } = [];

	/// <summary>
	/// Adds a new sample to the collection with the specified route, type, and description.
	/// </summary>
	/// <param name="id">The id associated with the sample. This cannot be null or empty.</param>
	/// <param name="created">The creation date of the StackOverflow question associated with the sample.</param>
	/// <param name="route">The route associated with the sample. This cannot be null or empty.</param>
	/// <param name="routeType">The type of the route, represented as a <see cref="Type"/>. This cannot be null.</param>
	/// <param name="snippet">A short description of the sample. This cannot be null or empty.</param>
	/// <param name="description">A long description of the sample. This cannot be null or empty.</param>
	public void RegisterSample(string id, DateTime created, string route, Type routeType, string snippet, string description)
	{
		Samples.Add(new Sample(id, created, route, routeType, snippet, description));
		Routing.RegisterRoute(route, routeType);
	}
}
