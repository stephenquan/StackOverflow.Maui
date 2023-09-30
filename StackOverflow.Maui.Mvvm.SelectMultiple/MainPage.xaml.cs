using System.Diagnostics;
using System.Windows.Input;

namespace StackOverflow.Maui.Mvvm.SelectMultiple;

public class Person
{
    public string Name { get; set; }
}

public partial class MainPage : ContentPage
{
    public List<Person> Persons { get; set; } = new(
        new string[] { "Tom", "Dick", "Harry" }
        .Select(s => new Person() { Name = s }));
    public IList<object> SelectedPersons { get; set; } = new List<object>();
    public ICommand CheckCommand { get; set; }
    public MainPage()
    {
        CheckCommand = new Command(() =>
        {
            string SelectedPersonsText = string.Join(", ", SelectedPersons.Select(p => ((Person)p).Name));
            Debug.WriteLine($"SelectedPersons = [{SelectedPersons.Count}] {SelectedPersonsText}");
        });
        OnPropertyChanged(nameof(CheckCommand));
        BindingContext = this;
        InitializeComponent();
    }
}