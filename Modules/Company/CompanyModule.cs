using Prism.Modularity;
using Prism.Regions;
using Microsoft.Practices.Unity;

namespace EFTuts.Modules.Company
{
    public class CompanyModule : IModule
    {
        private IRegionManager _regionManager;

        public CompanyModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
        }
    }
}