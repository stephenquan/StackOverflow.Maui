using System.Windows.Input;
using SQuan.Helpers.Maui.Mvvm;

namespace SO79696605;

/// <summary>
/// 
/// </summary>
public partial class MyImage : Image
{
	/// <summary>
	/// 
	/// </summary>
	[BindableProperty] public partial ICommand? LongPressedCommand { get; set; }

	/// <summary>
	/// 
	/// </summary>
	[BindableProperty] public partial object? LongPressedCommandParameter { get; set; }

	/// <summary>
	/// 
	/// </summary>
	public MyImage()
	{
		InitializeComponent();
	}
}
