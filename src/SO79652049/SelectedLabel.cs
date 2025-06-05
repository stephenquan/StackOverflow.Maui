using CommunityToolkit.Maui.Markup;
using SQuan.Helpers.Maui.Mvvm;

namespace SO79652049;

/// <summary>Represents a label that can be selected, with visual feedback based on its selection state.</summary>
public partial class SelectableLabel : Label
{
	/// <summary>Gets or sets a value indicating whether the item is selected.</summary>
	[BindableProperty] public partial bool IsSelected { get; set; } = false;

	/// <summary>Initializes a new instance of the <see cref="SelectableLabel"/> class.</summary>
	public SelectableLabel() : base()
	{
		this.Bind(Label.BackgroundColorProperty, static (SelectableLabel ctx) => ctx.IsSelected, source: this, convert: (bool isSelected) => isSelected ? Colors.SkyBlue : Colors.Transparent);
	}
}
