using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfTestChangeLanguage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowT win = new MainWindowT();
            win.DataContext =new MainWindowViewModel();
            win.Show();
        }
    }

}
