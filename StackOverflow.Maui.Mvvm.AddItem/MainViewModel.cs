using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace StackOverflow.Maui.Mvvm.AddItem;

public partial class MainViewModel : ObservableObject
{
    public event EventHandler<int> ScrollRequested;
    static Random rnd = new Random();

    public ObservableCollection<FeedItem> FeedItems { get; } = new();

    [RelayCommand]
    async Task AddItem(FeedItem newItem)
    {
        FeedItems.Insert(0, newItem);
        ScrollRequested?.Invoke(this, 0);
    }

    [RelayCommand]
    async Task AddRandomItem()
    {
        await AddItem(new FeedItem() { Title = $"Item {rnd.Next()}" });
    }
}
