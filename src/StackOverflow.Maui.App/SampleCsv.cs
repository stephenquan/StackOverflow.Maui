// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

namespace StackOverflow.Maui.App;

/// <summary>
/// Represents the definition of a sample as read from the CSV file.
/// </summary>
public class SampleCsv
{
	/// <summary>
	/// Gets or sets the unique identifier for the sample.
	/// </summary>
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the StackOverflow question creation date.
	/// </summary>
	public string Created { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets when the question was answered.
	/// </summary>
	public string Answered { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the title which is a short description of the sample.
	/// </summary>
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the description which is a long description of the sample.
	/// </summary>
	public string Description { get; set; } = string.Empty;
}
