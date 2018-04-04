using ModernChrome;
using Prism.Regions;

namespace Shell.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            // show splash scewwn first
            //new SplashWindow().ShowDialog();

            // register top menu to header region
            regionManager.RegisterViewWithRegion("headerRegion", typeof(Header.TopMenu));

            // register dockmanger to content region
            regionManager.RegisterViewWithRegion("contentRegion", typeof(Content.DockManager));

            // register statusbar to footer region
            regionManager.RegisterViewWithRegion("footerRegion", typeof(Footer.Footer));
        }
    }
}
