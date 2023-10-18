using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackView.Maui.Mvvm.CheckBox;

public class Video : INotifyPropertyChanged
{
    public event EventHandler VideoChanged;

    public int Id { get; set; }

    private bool _videoIsChecked = false;
    public bool VideoIsChecked
    {
        get => _videoIsChecked;
        set
        {
            if (_videoIsChecked == value) return;
            _videoIsChecked = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VideoIsChecked)));
            VideoChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
