namespace SO79745777;

/// <summary>
/// Defines a contract for a service that manages messages and displays them to the user.
/// </summary>
/// <remarks>This interface provides a mechanism to manage a message through the <see cref="Message"/> property
/// and to display it asynchronously using the <see cref="ShowPopupAsync"/> method.
/// Implementations of this interface may define the specific behavior for displaying messages,
/// such as showing a popup dialog or a notification.</remarks>
public interface IMessageService
{
	/// <summary>
	/// Gets or sets the message associated with the current operation or context.
	/// </summary>
	string Message { get; set; }

	/// <summary>
	/// Displays a popup asynchronously to the user.
	/// </summary>
	/// <remarks>This method is non-blocking and returns a task that completes when the popup is dismissed.
	/// Ensure that the calling code awaits the returned task to handle any post-popup logic.</remarks>
	/// <returns>A task that represents the asynchronous operation. The task completes when the popup is closed.</returns>
	Task ShowPopupAsync();
}
