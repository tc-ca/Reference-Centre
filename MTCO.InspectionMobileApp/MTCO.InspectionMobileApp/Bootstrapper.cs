using Microsoft.Practices.Unity;
using Prism.Unity;
using MTCO.InspectionMobileApp.Views;
using System.Windows;
using Prism.Modularity;
using MTCO.InspectionMobileApp.BLL.Local.Contracts.Reference;
using MTCO.InspectionMobileApp.BLL.Local.Services.Reference;

namespace MTCO.InspectionMobileApp
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
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            
            catalog.AddModule(typeof(ReferenceCentre.RCModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.RegisterTypeIfMissing(typeof(IReferenceService), typeof(ReferenceService), true); 
        }

    }
}
