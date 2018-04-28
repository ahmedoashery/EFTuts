using System.Windows;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Unity;
using EFTuts.Shell.MyApp.Views;
using Customers;

namespace EFTuts.Shell.MyApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog moduleCatalog = new ModuleCatalog();

            //moduleCatalog.AddModule(typeof(CustomersModule));
        }
    }
}
