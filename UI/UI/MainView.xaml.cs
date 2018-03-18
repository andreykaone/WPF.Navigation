using System.Windows.Controls;
using UI.Interfaces;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
