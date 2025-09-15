namespace SO79745777;

/// <summary>
/// Provides a default implementation of the <see cref="IMessageService"/> interface for displaying messages.
/// </summary>
/// <remarks>This service uses the current shell to display a popup alert with the specified message.</remarks>
public class DefaultMessageService : IMessageService
{
	/// <summary>
	/// Gets or sets the message associated with the current instance.
	/// </summary>
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// Displays a popup message to the user asynchronously.
	/// </summary>
	/// <remarks>The popup contains the message specified by the <see cref="Message"/> property  and an "OK" button to dismiss it.
	/// This method is intended for use in applications  utilizing the Shell navigation framework.</remarks>
	/// <returns>A task that represents the asynchronous operation.</returns>
	public async Task ShowPopupAsync()
	{
		await Shell.Current.DisplayAlert("Message", Message, "OK");
	}
}
