namespace StackOverflow.Maui.App;

/// <summary>
/// Represents a sample class with no specific functionality.
/// </summary>
public class Sample
{
	/// <summary>
	/// Gets or sets the StackOverflow id.
	/// </summary>
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the StackOverflow question creation date.
	/// </summary>
	public DateTime Created { get; set; }

	/// <summary>
	/// Gets or sets when the question was answered.
	/// </summary>
	public DateTime Answered { get; set; }

	/// <summary>
	/// Gets or sets the route of the sample.
	/// </summary>
	public string Route { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the type associated with the route.
	/// </summary>
	public Type RouteType { get; set; }

	/// <summary>
	/// Gets or sets the snippet which is a short description of the sample.
	/// </summary>
	public string Snippet { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the description which is a long description of the sample.
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets a summary text that can be used for page titles.
	/// </summary>
	public string TitleText => $"{Id} {Snippet}";

	/// <summary>
	/// Gets the link text to view the question on StackOverflow.
	/// </summary>
	public FormattedString LinkText
	{
		get
		{
			FormattedString fs = new();
			Span span;
			fs.Spans.Add(span = new Span { Text = "View " });
			fs.Spans.Add(span = new Span { Text = $"{TitleText} on StackOverflow", TextColor = Colors.Blue, TextDecorations = TextDecorations.Underline });
			span.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(async () =>
				{
					if (Id is not null)
					{
						await Launcher.OpenAsync($"https://stackoverflow.com/questions/{Id}");
					}
				})
			});
			return fs;
		}
	}

	/// <summary>
	/// Instantiates a new instance of the <see cref="Sample"/> class.
	/// </summary>
	/// <param name="id"></param>
	/// <param name="created"></param>
	/// <param name="answered"></param>"
	/// <param name="route"></param>
	/// <param name="routeType"></param>
	/// <param name="snippet"></param>
	/// <param name="description"></param>
	public Sample(string id, DateTime created, DateTime answered, string route, Type routeType, string snippet, string description)
	{
		Id = id;
		Created = created;
		Answered = answered;
		Route = route;
		RouteType = routeType;
		Snippet = snippet;
		Description = description;
	}
}
