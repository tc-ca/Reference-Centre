using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

namespace MTCO.InspectionMobileApp.ReferenceCentre
{
    public class RCModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;
        public RCModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void Initialize()
        {
            _container.RegisterTypeForNavigation<Views.ReferenceCentre>("RCMainPage");
        }
    }
}
