using CommunityToolkit.Mvvm.ComponentModel;

namespace StackOverflow.Maui.Mvvm.Initializer;

public partial class MainCategory : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Image))]
    private string _name;

    public string Image
        => $"{Name.ToLower().Replace(" ", "_")}.png";
}
