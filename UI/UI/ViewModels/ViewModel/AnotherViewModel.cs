using System;
using GalaSoft.MvvmLight.Command;
using UI.Interfaces;

namespace UI.ViewModels
{
    class AnotherViewModel : BaseViewModel, IAnotherViewModel
    {
        public AnotherViewModel(IAnotherView view/*, SimpleIoc container*/) : base(view/*, container*/)
        {
        }

        //example
        public RelayCommand GoToMainViewCommand { get; set; }

        public string AnotherHello => "Another hello from another view :)";
    }
}
