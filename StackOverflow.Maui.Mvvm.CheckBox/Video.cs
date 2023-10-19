using CommunityToolkit.Mvvm.ComponentModel;

namespace StackView.Maui.Mvvm.CheckBox;

public partial class Video : ObservableObject
{
    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private bool _videoIsChecked = false;
}
