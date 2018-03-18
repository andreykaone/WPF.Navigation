using UI.Interfaces;

namespace UI.ViewModels
{
    class MainViewModel : BaseViewModel, IMainViewModel
    {
        public MainViewModel(IMainView view) : base(view)
        {
        }

        public string HelloMain => "Привет, ты на главной вьюхе!";
    }
}
