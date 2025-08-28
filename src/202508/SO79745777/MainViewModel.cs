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

	/// <summary>
	/// Occurs when a message is received or processed.
	/// </summary>

	public event EventHandler<MessageEventArgs>? SendMessageEvent;

	/// <summary>
	/// Sends the current message by raising the <see cref="SendMessageEvent"/> event.
	/// </summary>
	[RelayCommand]
	public void SendMessage()
	{
		SendMessageEvent?.Invoke(this, new MessageEventArgs(Message));
	}
}
