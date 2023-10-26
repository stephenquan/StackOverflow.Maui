using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;

namespace StackOverflow.Maui.Mvvm.Initializer;

public partial class MainPage : ContentPage
{
    int count = 0;
    public ObservableCollection<MainCategory> MainCategories;

    public MainPage()
    {
        InitializeComponent();

        MainCategories = new ObservableCollection<MainCategory>(
            "Gloves,Punch Bags,Footwear,Club Shop,Protective,Apparel,Equipment,Sale"
            .Split(",").Select(n => new MainCategory { Name = n }));

        Debug.WriteLine($"MainCategories: {JsonSerializer.Serialize(MainCategories)}");
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}