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
    public  class MainWindowViewModel :NotifyPropertyChanged
    {
        //private readonly LocalizationService _localizationService;
        //public LoadLanguage LoadLanguageVM {  get; set; }

        public MainWindowViewModel()
        {
            //_localizationService = new LocalizationService();
            //LoadLanguageVM = new LoadLanguage();
            ChangeLanguage("en"); // Default Language
        }

        public string MenuDashboard => LocalizationService.GetString("MenuDashboard");
        public string MenuProducts => LocalizationService.GetString("MenuProducts");

        public ICommand ChangeLanguageCommand => new RelayCommand<string>(ChangeLanguage);

        private void ChangeLanguage(string languageCode)
        {
            //LoadLanguageVM.ChangeLanguage(languageCode);
            LocalizationService.SetCulture(languageCode);
            OnPropertyChanged(nameof(MenuDashboard));
            OnPropertyChanged(nameof(MenuProducts));
        }
    }
}
