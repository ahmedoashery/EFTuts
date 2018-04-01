using Prism.Regions;
using Shell.Views.splashscreens;
using System;

namespace Shell.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            // show splash scewwn first
            new SplashWindow().ShowDialog();

            // register top menu to header region
            regionManager.RegisterViewWithRegion("headerRegion", typeof(header.TopMenu));

            // register dockmanger to content region
            regionManager.RegisterViewWithRegion("contentRegion", typeof(content.DockManager));

            // register statusbar to footer region
            regionManager.RegisterViewWithRegion("footerRegion", typeof(footer.StatusBar));
        }
    }
}
