namespace UI.Interfaces
{
    public interface IView
    {
        object DataContext { get; set; }
    }

    public interface IViewModel
    {
        IView View { get; set; }
    }
}
