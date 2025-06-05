using CommunityToolkit.Mvvm.ComponentModel;

namespace SO79652049;

public partial class ItemInfo : ObservableObject
{
	[ObservableProperty] public partial string Name { get; set; } = string.Empty;
	[ObservableProperty] public partial bool IsSelected { get; set; } = false;
}
