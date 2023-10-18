using CommunityToolkit.Mvvm.ComponentModel;

namespace StackView.Maui.Mvvm.CheckBox;

public partial class Video : ObservableObject
{
    public event EventHandler VideoChanged;

    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private bool _videoIsChecked = false;

    partial void OnVideoIsCheckedChanged(bool oldValue, bool newValue)
    {
        VideoChanged?.Invoke(this, EventArgs.Empty);
    }
}
