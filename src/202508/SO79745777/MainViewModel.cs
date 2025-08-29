using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SO79745777;

/// <summary>
/// Represents the main view model for the application.
/// </summary>
public partial class MainViewModel : ObservableObject
{
	/// <summary>
	/// Gets or sets the message text.
	/// </summary>
	[ObservableProperty]
	public partial string Message { get; set; } = "Hello, World!";

	IMessageService messageService { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MainViewModel"/> class.
	/// </summary>
	/// <param name="messageService">The service used to manage and display messages. This parameter cannot be null.</param>
	public MainViewModel(IMessageService messageService)
	{
		this.messageService = messageService;
	}

	/// <summary>
	/// Sends a message by setting the current message and displaying it in a popup.
	/// </summary>
	/// <remarks>This method sets the <see cref="Message"/> property of the message service and then asynchronously displays a popup.
	/// Ensure that the <see cref="Message"/> property is set to a non-null, non-empty value before calling this method.</remarks>
	/// <returns></returns>
	[RelayCommand]
	public async Task SendMessage()
	{
		messageService.Message = Message;
		await messageService.ShowPopupAsync();
	}
}
