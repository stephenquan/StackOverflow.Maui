namespace SO79727653;

/// <summary>
/// This class represents a picker control view that allows users to select an item from a list.
/// </summary>
/// <typeparam name="T"></typeparam>
public partial class PickerControlView<T> : CommunityToolkit.Maui.Views.Popup<T>
{
	/// <summary>
	/// Bindable property for <see cref="ItemsSource"/>.
	/// </summary>
	public static readonly BindableProperty ItemsSourceProperty =
		BindableProperty.Create(nameof(ItemsSource), typeof(System.Collections.IEnumerable), typeof(PickerControlView<T>), null);

	/// <summary>
	/// Gets or sets the items source for the picker control view.
	/// </summary>
	public System.Collections.IEnumerable? ItemsSource
	{
		get => (System.Collections.IEnumerable)GetValue(ItemsSourceProperty);
		set => SetValue(ItemsSourceProperty, value);
	}

	/// <summary>
	/// Bindable property for <see cref="ItemTemplate"/>.
	/// </summary>
	public static readonly BindableProperty ItemTemplateProperty =
		BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(PickerControlView<T>), default(DataTemplate));

	/// <summary>
	/// Gets or sets the data template for the items in the picker control view.
	/// </summary>
	public DataTemplate? ItemTemplate
	{
		get => (DataTemplate)GetValue(ItemTemplateProperty);
		set => SetValue(ItemTemplateProperty, value);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PickerControlView{T}"/> class.
	/// </summary>
	public PickerControlView()
	{
		CollectionView clPickerView = new CollectionView();

		clPickerView.SelectionMode = SelectionMode.Single;

		clPickerView.SetBinding(
			CollectionView.ItemsSourceProperty,
			new Binding(
				nameof(ItemsSource),
				BindingMode.OneWay,
				source: this));

		clPickerView.SetBinding(
			CollectionView.ItemTemplateProperty,
			new Binding(
				nameof(ItemTemplate),
				BindingMode.OneWay,
				source: this));

		clPickerView.SelectionChanged += async (s, e) =>
		{
			if (e.CurrentSelection is not null
				&& e.CurrentSelection.Count >= 1
				&& e.CurrentSelection[0] is T selectedItem)
			{
				await this.Dispatcher.DispatchAsync(async () =>
				{
					await this.CloseAsync(selectedItem);
				});
			}
		};

		this.Content = clPickerView;
	}
}
