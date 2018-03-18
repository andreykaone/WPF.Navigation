using UI.Interfaces;

namespace UI.ViewModels
{
    class AnotherViewModel : BaseViewModel, IAnotherViewModel
    {
        public AnotherViewModel(IAnotherView view/*, SimpleIoc container*/) : base(view/*, container*/)
        {
        }

        public string AnotherHello => "Another hello from another view :)";
    }
}
