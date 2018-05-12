using Prism.Modularity;
using Prism.Regions;
using Microsoft.Practices.Unity;
using Prism.Unity;
using EFTuts.Modules.Users.Views;

namespace EFTuts.Modules.Users
{
    public class UsersModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public UsersModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<Login>();
        }
    }
}