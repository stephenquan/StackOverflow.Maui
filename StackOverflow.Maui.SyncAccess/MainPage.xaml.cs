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
            mylabel.Text = mystringvar + " (Step 2)";
        });
        await Task.Delay(500);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            Debug.WriteLine($"Step 3: MainThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 3: MainThread: 1
            mylabel.Text = mystringvar + " (Step 3)"; ;
        });
        await Task.Delay(500);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            Debug.WriteLine($"Step 4: MainThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 4: MainThread: 1
            mylabel.Text = mystringvar + " (Step 4)"; ;
        });
        await Task.Delay(500);
        await MainThread.InvokeOnMainThreadAsync(() =>
        {
            Debug.WriteLine($"Step 5: MainThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 5: MainThread: 1
            mylabel.Text = mystringvar;
        });
        Debug.WriteLine($"Step 6: MyThread: {Thread.CurrentThread.ManagedThreadId}"); // Step 6: MyThread: 10
        mystringvar = "WHAT I GOT (NOT!)";
    }
}