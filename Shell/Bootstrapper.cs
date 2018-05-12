using System.Windows;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Unity;
using EFTuts.Shell.MyApp.Views;
using Customers;
using EFTuts.Modules.Users.Views;

namespace EFTuts.Shell.MyApp
{
    public class Bootstrapper : UnityBootstrapper
    {
        public bool session = false;
        protected override DependencyObject CreateShell()
        {
            // check logged in user
            if (session == true)
            {
                return Container.Resolve<MainWindow>();
            }
            else
            {
                return Container.Resolve<Login>();
            }
            
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
