using System.Diagnostics;

namespace StackOverflow.Maui.PanZoom;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        Debug.WriteLine($"PinchStatus={e.Status}, ScaleOrigin={e.ScaleOrigin}, Scale={e.Scale}");
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        Debug.WriteLine($"TotalX={e.TotalX}, TotalY={e.TotalY}");
    }
}