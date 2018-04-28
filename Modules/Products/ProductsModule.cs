using EFTuts.Modules.Products.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace EFTuts.Modules.Products
{
    public class ProductsModule : IModule
    {
        private IRegionManager _regionManager;

        public ProductsModule(IUnityContainer container, IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //_regionManager.RegisterViewWithRegion("ContentRegion",typeof(ProductsList));
        }
    }
}