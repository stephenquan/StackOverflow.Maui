// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App.SO76746572;

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
@font-face { font-family: XComic Sans MS; src: url('comic.ttf'); }
@font-face { font-family: XComic Sans MS Bold; src: url('comicbd.ttf'); }
@font-face { font-family: XComic Sans MS Italic; src: url('comici.ttf'); }
@font-face { font-family: XComic Sans MS Bold Italic; src: url('comicz.ttf'); }
</style>
</head>
<body>
	<p><Span style='font-family:XComic Sans MS;'>Hello World!</Span ></p>
	<p><Span style='font-family:XComic Sans MS Bold;'>Hello World!</Span ></p>
	<p><Span style='font-family:XComic Sans MS Italic;'>Hello World!</Span ></p>
	<p><Span style='font-family:XComic Sans MS Bold Italic;'>Hello World!</Span ></p>
</body>
</html>
"
		};
	}
}
