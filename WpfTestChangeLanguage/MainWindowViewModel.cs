using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Collections.Specialized;
using InvestmentManage.Presentation.Helpers;

namespace WpfTestChangeLanguage
{
    public partial class MainWindowViewModel : NotifyPropertyChanged
    {
        private readonly LocalizationService _localizationService;

        public MainWindowViewModel()
        {
            _localizationService = new LocalizationService();
            ChangeLanguage("en"); // Default Language
        }

        public string MenuDashboard => _localizationService.GetString("MenuDashboard");
        public string MenuProducts => _localizationService.GetString("MenuProducts");

        public ICommand ChangeLanguageCommand => new RelayCommand<string>(ChangeLanguage);

        private void ChangeLanguage(string languageCode)
        {
            _localizationService.SetCulture(languageCode);
            OnPropertyChanged(nameof(MenuDashboard));
            OnPropertyChanged(nameof(MenuProducts));
        }
    }
}
