namespace SO79745777;

/// <summary>
/// Provides data for an event that is triggered when a message is received.
/// </summary>
public class MessageEventArgs : EventArgs
{
	/// <summary>
	/// Gets the message associated with the current instance.
	/// </summary>
	public string Message { get; }

	/// <summary>
	/// Provides data for an event that involves a message.
	/// </summary>
	/// <param name="message">The message associated with the event. Cannot be null.</param>
	public MessageEventArgs(string message)
	{
		Message = message;
	}
}
