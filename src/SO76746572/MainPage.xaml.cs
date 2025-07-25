namespace SO76746572;

/// <summary>
/// 
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// 
	/// </summary>
	public MainPage()
	{
		InitializeComponent();

		webView.Source = new HtmlWebViewSource
		{
			Html = @"
<!DOCTYPE html>
<html>
<head>
	<style>
@font-face { font-family: Comic Sans MS; src: url('comic.ttf'); }
@font-face { font-family: Comic Sans MS Bold; src: url('comicbd.ttf'); }
@font-face { font-family: Comic Sans MS Italic; src: url('comici.ttf'); }
@font-face { font-family: Comic Sans MS Bold Italic; src: url('comicz.ttf'); }
</style>
</head>
<body>
	<p><Span style='font-family:Comic Sans MS;'>Hello World!</Span ></p>
	<p><Span style='font-family:Comic Sans MS Bold;'>Hello World!</Span ></p>
	<p><Span style='font-family:Comic Sans MS Italic;'>Hello World!</Span ></p>
	<p><Span style='font-family:Comic Sans MS Bold Italic;'>Hello World!</Span ></p>
</body>
</html>
"
		};
	}
}
