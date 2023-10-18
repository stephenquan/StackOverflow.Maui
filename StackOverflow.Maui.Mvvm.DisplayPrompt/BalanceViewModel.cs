using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Maui.Mvvm.DisplayPrompt;

public partial class BalanceViewModel : ObservableObject
{
    [ObservableProperty]
    private int _balanceAmount;

    [ObservableProperty]
    private string _newAmount;

    [RelayCommand]
    private void AddAmount()
    {
        if (int.TryParse(NewAmount, out int newAmount))
        {
            BalanceAmount += newAmount;
            NewAmount = string.Empty;
        }
    }
}
