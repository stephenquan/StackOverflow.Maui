using CommunityToolkit.Mvvm.ComponentModel;

namespace SO79646081.Models;

/// <summary>Represents a custom field with a title that can be observed for changes.</summary>
public partial class CustomField : ObservableObject
{
	/// <summary>Gets or sets the title of the item.</summary>
	[ObservableProperty]
	public partial string Title { get; set; } = string.Empty;
}
