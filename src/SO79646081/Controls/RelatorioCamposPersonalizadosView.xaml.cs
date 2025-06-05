using SO79646081.Models;

namespace SO79646081.Controls;

/// <summary>A custom view.</summary>
public partial class RelatorioCamposPersonalizadosView : ContentView
{
	/// <summary>Gets the view model associated with the current binding context.</summary>
	public RelatorioCamposPersonalizadosViewModel? VM => BindingContext as RelatorioCamposPersonalizadosViewModel;

	/// <summary>Initializes a new instance of the <see cref="RelatorioCamposPersonalizadosView"/> class.</summary>
	public RelatorioCamposPersonalizadosView()
	{
		InitializeComponent();
	}
}
