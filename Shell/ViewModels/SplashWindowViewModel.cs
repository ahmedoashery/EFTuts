using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFTuts.Shell.MyApp.ViewModels
{
	public class SplashWindowViewModel : BindableBase
	{
        private string _splashScreenText = "Initializing...";
        public string SplashScreenText
        {
            get { return _splashScreenText; }
            set { SetProperty(ref _splashScreenText, value); }
        }

        public SplashWindowViewModel()
        {

        }
	}
}
