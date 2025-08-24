using CommunityToolkit.Mvvm.ComponentModel;

namespace SO79743710;

/// <summary>
/// Represents a serial communication device with configurable baud rate settings.
/// </summary>
public partial class SerialDevice : ObservableObject, IDevice
{
	/// <summary>
	/// Gets the list of supported baud rates for communication.
	/// </summary>
	public List<int> BaudRateSource { get; } = [110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 256000];

	/// <summary>
	/// Gets or sets the baud rate for the serial communication.
	/// </summary>
	[ObservableProperty]
	public partial int BaudRate { get; set; } = 9600;
}
