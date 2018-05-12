using Prism.Commands;
using Prism.Mvvm;
using System;

namespace EFTuts.Shell.MyApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Main Window";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                SetProperty(ref _isEnabled, value);
            }
        }

        private string _updateText;
        public string UpdateText
        {
            get { return _updateText; }
            set { SetProperty(ref _updateText, value); }
        }

        public DelegateCommand ExecuteDelegateCommand { get; set; }

        public MainWindowViewModel()
        {
            ExecuteDelegateCommand = new DelegateCommand(Execute, CanExecute);
        }

        private void Execute()
        {
            UpdateText = $"Updated: {DateTime.Now}";
        }

        private bool CanExecute()
        {
            return IsEnabled;
        }
    }
}
