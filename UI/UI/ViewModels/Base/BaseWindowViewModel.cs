using GalaSoft.MvvmLight.Ioc;
using UI.Interfaces;

namespace UI.ViewModels
{
    class BaseWindowViewModel : BaseNotification, IWindowViewModel
    {
        private ISimpleIoc _container;
        private IView _view;

        public BaseWindowViewModel(IWindow window)
        {
            Window = window;
            Window.DataContext = this;

            Container = SimpleIoc.Default;
        }

        public IWindow Window { get; set; }

        ISimpleIoc Container
        {
            get
            {
                return _container;
            }
            set
            {
                if (value == null)
                    return;

                _container = value;
            }

        }

        public IView View
        {
            get
            {
                return _view;
            }
            set
            {
                if (value == null)
                    return;

                _view = value;
                OnPropertyChanged();
            }
        }

        protected void ShowView<T>() where T : IViewModel
        {
            var view = SimpleIoc.Default.GetInstance<T>().View;
            View = view;
        }
    }
}
