// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;

namespace StackOverflow.Maui.App.SO79726492;

#pragma warning disable CS1591 // Suppress warnings for missing XML comments

public partial class JSONEditorViewModel : ObservableObject
{
	ILogger? logger { get; } = (ILogger?)IPlatformApplication.Current?.Services.GetService(typeof(ILogger<JSONEditorViewModel>));

	[ObservableProperty]
	public partial string Text { get; set; }

	[ObservableProperty]
	public partial string JsonValidStatus { get; set; }

	[ObservableProperty]
	public partial Color FormattingColour { get; set; } = Colors.White;

	[ObservableProperty]
	public partial bool IsJSONValid { get; set; }

	[ObservableProperty]
	public partial bool IsJsonValidatorEnabled { get; set; } = true;

	partial void OnTextChanged(string value)
	{
		logger?.LogInformation("Text changed: {Text}", System.Text.Json.JsonSerializer.Serialize(value));

		FormattingColour = Colors.White;
		JsonValidStatus = "";
	}

	[RelayCommand]
	public void FormatAndValidate()
	{
		logger?.LogInformation("FormatAndValidate");

		try
		{
			var doc = System.Text.Json.JsonDocument.Parse(Text);
			if (doc is not null)
			{
				JsonValidStatus = "Valid JSON";
				IsJSONValid = true;
				FormattingColour = Colors.Green;
				Text = System.Text.Json.JsonSerializer.Serialize(doc, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }).Replace("\n", "");
			}
		}
		catch
		{
			FormattingColour = Colors.Red;
			JsonValidStatus = "Invalid JSON";
			IsJSONValid = false;
		}

		logger?.LogInformation("FormatAndValidate (done)");
	}
}
