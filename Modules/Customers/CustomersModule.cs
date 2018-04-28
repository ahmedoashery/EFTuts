using Prism.Modularity;
using Prism.Regions;
using Microsoft.Practices.Unity;
using Modules.Customers.Views;

namespace Customers
{
    public class CustomersModule : IModule
    {
        private IRegionManager _regionManager;

        public CustomersModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(CustomersList));
        }
    }
}