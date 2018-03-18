using GalaSoft.MvvmLight.Command;
using UI.Interfaces;

namespace UI.ViewModels
{
    class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IMainWindow window) : base(window)
        {
            ExitCommand = new RelayCommand(Exit);
            ShowAnotherViewCommand = new RelayCommand(ShowAnotherView);
            ShowMainViewCommand = new RelayCommand(ShowMainView);
            Id = 55;

            ShowView<IMainViewModel>();
        }

        private void ShowMainView()
        {
            ShowView<IMainViewModel>();
        }

        private void ShowAnotherView()
        {
            ShowView<IAnotherViewModel>();
        }

        private void Exit() => App.Current.Shutdown();

        public RelayCommand ExitCommand { get; set; }
        public RelayCommand ShowAnotherViewCommand { get; set; }
        public RelayCommand ShowMainViewCommand { get; set; }

        public int Id;
    }
}
