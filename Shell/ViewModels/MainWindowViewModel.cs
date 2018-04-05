using Prism.Mvvm;

namespace EFTuts.Shell.MyApp
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Main Window";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
