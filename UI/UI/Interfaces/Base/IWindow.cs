namespace UI.Interfaces
{
    public interface IWindow
    {
        object DataContext { get; set; }
    }

    public interface IWindowViewModel
    {
        IWindow Window { get; set; }
    }
}
