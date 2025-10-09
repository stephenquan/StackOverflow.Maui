// Copyright (c) Stephen Quan.
// Licensed under the MIT license.

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace StackOverflow.Maui.App.SO79646081.Models;

/// <summary>
/// Represents a view model.
/// </summary>
public partial class RelatorioCamposPersonalizadosViewModel : ObservableObject
{
	/// <summary>
	/// Gets the collection of custom fields associated with the current object.
	/// </summary>
	public ObservableCollection<CustomField> CustomFields { get; } = [];

	/// <summary>
	/// Adds a new custom field to the collection.
	/// </summary>
	/// <param name="customField">The custom field to be added. This parameter is currently unused in the method implementation.</param>
	[RelayCommand]
	public void AddCustomField(CustomField customField)
	{
		CustomFields.Add(new CustomField() { Title = $"New Field {DateTime.Now}" });
	}

	/// <summary>Edits the specified custom field by updating its title.</summary>
	[RelayCommand]
	public void EditCustomField(CustomField customField)
	{
		customField.Title = $"Edited Title {DateTime.Now}";
	}
}
