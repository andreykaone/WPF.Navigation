using GalaSoft.MvvmLight.Ioc;
using System.Windows;
using UI.Interfaces;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper.Initialize();

            IMainWindowViewModel window = SimpleIoc.Default.GetInstance<IMainWindowViewModel>();
            MainWindow = (MainWindow)window.Window;
            MainWindow.ShowDialog();
        }
    }
}