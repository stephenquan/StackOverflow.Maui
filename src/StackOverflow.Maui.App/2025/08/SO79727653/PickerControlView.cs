// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Maui.Markup;
using SQuan.Helpers.Maui.Mvvm;

namespace StackOverflow.Maui.App.SO79727653;

/// <summary>
/// This class represents a picker control view that allows users to select an item from a list.
/// </summary>
/// <typeparam name="T"></typeparam>
public partial class PickerControlView<T> : CommunityToolkit.Maui.Views.Popup<T>
{
	/// <summary>
	/// Gets or sets the items source for the picker control view.
	/// </summary>
	[BindableProperty] public partial System.Collections.IEnumerable? ItemsSource { get; set; }

	/// <summary>
	/// Gets or sets the data template for the items in the picker control view.
	/// </summary>
	[BindableProperty] public partial DataTemplate? ItemTemplate { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="PickerControlView{T}"/> class.
	/// </summary>
	public PickerControlView()
	{
		CollectionView clPickerView = new CollectionView { SelectionMode = SelectionMode.Single }
			.Bind(CollectionView.ItemsSourceProperty, nameof(ItemsSource), BindingMode.OneWay, source: this)
			.Bind(CollectionView.ItemTemplateProperty, nameof(ItemTemplate), BindingMode.OneWay, source: this);
		clPickerView.SelectionChanged += async (s, e) =>
		{
			if (e.CurrentSelection is not null && e.CurrentSelection.Count >= 1 && e.CurrentSelection[0] is T selectedItem)
			{
				await this.Dispatcher.DispatchAsync(async () => await this.CloseAsync(selectedItem));
			}
		};
		this.Content = clPickerView;
	}
}
