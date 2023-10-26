// https://stackoverflow.com/questions/77311287/serialization-of-access-to-ui-thread-in-maui

using System.Diagnostics;

namespace StackOverflow.Maui.SyncAccess;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnChangeTextClicked(object sender, EventArgs e)
    {
        string mystringvar = null;
        mystringvar = "WHAT I WANT";
        Debug.WriteLine($"Step 1: MyThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 1: MyThread: 10
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            Debug.WriteLine($"Step 2: MainThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 2: MainThread: 1
            mylabel.Text = mystringvar;
        });
        Debug.WriteLine($"Step 3: MyThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 3: MyThread: 10
        mystringvar = "WHAT I GOT (NOT!)";
    }
}