using ModernChrome;
using Prism.Regions;

namespace EFTuts.Shell.MyApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            // show splash screen first
            //new SplashWindow().ShowDialog();

            // register top menu
            regionManager.RegisterViewWithRegion("TopMenuRegion", typeof(Header.TopMenu));

            // register toolbar
            regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(Header.Toolbar));

            // register footer and statusbar
            regionManager.RegisterViewWithRegion("FooterRegion", typeof(Footer.Footer));
        }
    }
}
