using CommunityToolkit.Mvvm.ComponentModel;
using System.Globalization;

namespace StackOverflow.Maui.Mvvm.CultureInfoFlag;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private CultureInfo _selectedLanguage;

    [ObservableProperty]
    private List<CultureInfo> _languages = new List<CultureInfo>()
    {
        new CultureInfo("en-US"),
        new CultureInfo("es-ES"),
        new CultureInfo("fr-FR")
    };
}
