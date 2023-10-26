using System.ComponentModel;

namespace StackOverflow.Maui.Mvvm.RadioButton;

public class Question : INotifyPropertyChanged
{
    private bool _isConforme;
    public bool IsConforme
    {
        get { return _isConforme; }
        set { _isConforme = value; OnPropertyChanged(nameof(IsConforme)); }
    }

    private bool _nonConforme;
    public bool NonConforme
    {
        get { return _nonConforme; }
        set { _nonConforme = value; OnPropertyChanged(nameof(NonConforme)); }
    }

    private bool _nonFait;
    public bool NonFait
    {
        get { return _nonFait; }
        set { _nonFait = value; OnPropertyChanged(nameof(NonFait)); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
