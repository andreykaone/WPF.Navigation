using GalaSoft.MvvmLight.Ioc;
using UI.Interfaces;
using UI.ViewModels;

namespace UI
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            //SimpleIoc.Default.Register<ISimpleIoc, SimpleIoc>();

            SimpleIoc.Default.Register<IMainWindow, MainWindow>();
            SimpleIoc.Default.Register<IMainWindowViewModel, MainWindowViewModel>();

            SimpleIoc.Default.Register<IMainView, MainView>();
            SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();

            SimpleIoc.Default.Register<IAnotherView, AnotherView>();
            SimpleIoc.Default.Register<IAnotherViewModel, AnotherViewModel>();
        }
    }
}
