using System.Windows.Controls;
using System.Windows.Navigation;

namespace UI
{
    class AdvancedNavigationService
    {
        private NavigationService _navigationService;
        public NavigationService Service
        {

            get { return _navigationService; }
            set
            {
                if (_navigationService != null)
                {
                    _navigationService.Navigated -= _navService_Navigated;
                }

                _navigationService = value;
                _navigationService.Navigated += _navService_Navigated;
            }
        }

        private static void _navService_Navigated(object sender, NavigationEventArgs e)
        {
            var page = e.Content as Page;
            if (page == null)
                return;

            page.DataContext = e.ExtraData;
        }


        public void Navigate(Page page, object context)
        {
            if (_navigationService == null || page == null)
            {
                return;
            }

            _navigationService.Navigate(page, context);
        }

        public void Navigate(Page page) => Navigate(page, null);

        public void Navigate(string uri, object context)
        {
            if (_navigationService == null || uri == null)
                return;

            //Page page = _resolver.GetPageInstance(uri);
            //Navigate(page, context);
        }

        public void Navigate(string uri) => Navigate(uri, null);
    }
}
