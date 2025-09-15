using System.Windows.Input;

namespace SO79745777;

/// <summary>
/// Represents a user interface component for composing and sending messages.
/// </summary>
public partial class MessageView : ContentView
{
	/// <summary>
	/// Bindable property for <see cref="Command"/>.
	/// </summary>
	public static readonly BindableProperty CommandProperty =
		BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(MessageView), null);

	/// <summary>
	/// Gets or sets the command to be executed when the message is sent.
	/// </summary>
	public ICommand Command
	{
		get => (ICommand)GetValue(CommandProperty);
		set => SetValue(CommandProperty, value);
	}

	/// <summary>
	/// Bindable property for <see cref="Message"/>.
	/// </summary>
	public static readonly BindableProperty MessageProperty =
		BindableProperty.Create(nameof(Message), typeof(string), typeof(MessageView), null);

	/// <summary>
	/// Gets or sets the message to sent.
	/// </summary>
	public string Message
	{
		get => (string)GetValue(MessageProperty);
		set => SetValue(MessageProperty, value);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MessageView"/> class.
	/// </summary>
	public MessageView()
	{
		InitializeComponent();
	}
}
