// https://stackoverflow.com/questions/77208180/net-maui-how-to-select-single-and-multiple-items-using-mvvm-and-collectionview/77208644#77208644

using System.Diagnostics;
using System.Windows.Input;

namespace StackOverflow.Maui.Mvvm.SelectMultiple;

public class Person
{
    public string Name { get; set; }
}

public partial class MainPage : ContentPage
{
    public IList<Person> Persons { get; } = new List<Person>("Tom,Dick,Harry".Split(",").Select(s => new Person() { Name = s }));
    public IList<object> SelectedPersons { get; } = new List<object>();
    public ICommand CheckCommand { get; }      
    public MainPage()
    {
        CheckCommand = new Command(() =>
        {
            string SelectedPersonsText = string.Join(", ", SelectedPersons.Select(p => ((Person)p).Name));
            Debug.WriteLine($"SelectedPersons = [{SelectedPersons.Count}] {SelectedPersonsText}");
        });
        BindingContext = this;
        InitializeComponent();
    }
}