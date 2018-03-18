using GalaSoft.MvvmLight.Ioc;
using UI.Interfaces;

namespace UI.ViewModels
{
    class BaseViewModel : BaseNotification, IViewModel
    {
        public BaseViewModel(IView view)
        {
            View = view;
            View.DataContext = this;

            Container = SimpleIoc.Default;
        }

        public ISimpleIoc Container
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
        public IView View { get; set; }


        private ISimpleIoc _container;
    }
}
