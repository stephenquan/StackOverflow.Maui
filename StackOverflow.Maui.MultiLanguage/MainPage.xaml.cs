using Microsoft.Extensions.Localization;
using StackOverflow.Maui.MultiLanguage.Resources.Strings;
using System.Diagnostics;
using System.Globalization;

namespace StackOverflow.Maui.MultiLanguage
{
    public partial class MainPage : ContentPage
    {
        public IStringLocalizer DefaultLocalizer { get; } = ServiceHelper.GetService<IStringLocalizer<HelloStrings>>();
        public LocalizedString this[string name] => DefaultLocalizer[name];
        public LocalizedString this[string name, params object[] args] => DefaultLocalizer[name, args];
        public XForm FormData { get; set; } = new XForm();
        public IList<CultureInfo> Languages { get; } = new List<CultureInfo>()
        {
            new CultureInfo("en-US"),
            new CultureInfo("fr-FR")
        };
        public CultureInfo enUS => Languages[0];
        public CultureInfo frFR => Languages[1];

        public CultureInfo DefaultCulture
        {
            get => CultureInfo.CurrentUICulture;
            set
            {
                if (value == null) return;
                value.ClearCachedData();
                CultureInfo.CurrentUICulture = value;
                RaisePropertyChanged();
            }
        }

        public CultureInfo NumericCulture
        {
            get => CultureInfo.CurrentCulture;
            set
            {
                if (value == null) return;
                value.ClearCachedData();
                CultureInfo.CurrentCulture = value;
                RaisePropertyChanged();
            }
        }

        public CultureInfo WelcomeCulture
        {
            get => WelcomeStrings.Culture ?? DefaultCulture;
            set
            {
                if (value == null) return;
                WelcomeStrings.Culture = value;
                RaisePropertyChanged();
            }
        }

        public void RaisePropertyChanged()
        {
            OnPropertyChanged(nameof(DefaultLocalizer));
            OnPropertyChanged("Item");
            OnPropertyChanged(nameof(FormData));
        }

        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
            DefaultCulture = frFR;
            NumericCulture = frFR;
            WelcomeStrings.Culture = enUS;
        }
    }
}