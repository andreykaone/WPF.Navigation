namespace UI
{
    class MainViewModel : BaseViewModel
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;

                _id = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
        }
    }
}
