using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Maui.Mvvm.RadioButton;

public class Audit : INotifyPropertyChanged
{
    public IList<Question> Questions { get; } = new List<Question>();

    public Audit()
    {
        Questions.Add(new Question());
        Questions.Add(new Question());

        for (int i = 0; i < Questions.Count; i++)
        {
            var currentQuestion = Questions[i];
            currentQuestion.PropertyChanged += (s, e) => Question_PropertyChanged(currentQuestion);
        }
    }

    private void Question_PropertyChanged(Question currentQuestion)
    {
        int index = Questions.IndexOf(currentQuestion);
        Debug.WriteLine($"Question_PropertyChanged: {index} {currentQuestion.IsConforme} {currentQuestion.NonConforme} {currentQuestion.NonFait}");
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
