namespace StackView.Maui.Mvvm.CheckBox;

public partial class MainPage : ContentPage
{
    public List<Video> VideoList { get; } = new List<Video>()
    {
        new Video() { Id=1, VideoIsChecked = false },
        new Video() { Id=2, VideoIsChecked = false },
        new Video() { Id=3, VideoIsChecked = false },
    };

    public List<Video> SelectedVideos => VideoList.Where(v => v.VideoIsChecked).ToList();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        for (int i = 0; i < VideoList.Count; i++)
            VideoList[i].PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Video.VideoIsChecked))
                    OnPropertyChanged(nameof(SelectedVideos));
            };
    }
}