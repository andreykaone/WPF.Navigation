using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public int Sooqa;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Sooqa = 5;
        }
    }
}