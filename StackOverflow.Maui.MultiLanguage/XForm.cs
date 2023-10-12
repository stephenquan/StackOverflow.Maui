using Microsoft.Extensions.Localization;
using StackOverflow.Maui.MultiLanguage.Resources.Strings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Maui.MultiLanguage;

public class XForm
{
    public IStringLocalizer XFormLocalizer { get; }
          = ServiceHelper.GetService<IStringLocalizer<WelcomeStrings>>();
    public decimal Amount { get; set; } = 123567.89m;
    public DateTime Xmas { get; set; } = new DateTime(DateTime.Now.Year, 12, 25);
}
