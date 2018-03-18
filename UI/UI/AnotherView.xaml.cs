using System.Windows.Controls;
using UI.Interfaces;

namespace UI
{
    /// <summary>
    /// Interaction logic for AnotherView.xaml
    /// </summary>
    public partial class AnotherView : UserControl, IAnotherView
    {
        public AnotherView()
        {
            InitializeComponent();
        }
    }
}
