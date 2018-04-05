using Branches.Views;
using Prism.Modularity;
using Prism.Regions;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace EFTuts.Modules.Branches
{
    public class BranchesModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public BranchesModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<ViewA>();
        }
    }
}