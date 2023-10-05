using System.ComponentModel;

namespace StackOverflow.Maui.Mvvm.Drawable;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public event EventHandler<float> ScoreChanged;
    private float _score = 50.0f;
    public float Score
    {
        get => _score;
        set
        {
            if (_score != value)
            {
                _score = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Score)));
                ScoreChanged?.Invoke(this, value);
            }
        }
    }
}
