using Microsoft.Practices.Unity;
using MTCO.InspectionMobileApp.Common;
using MTCO.InspectionMobileApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace MTCO.InspectionMobileApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IUnityContainer _container;
        private readonly IRegionManager _regionManager;
        private string _title = "Reference Centre — Centre de référence";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public DelegateCommand<string> NavigateCommand { get; private set; }
        public DelegateCommand<string> NavigateToFTAECommand { get; private set; }
        public DelegateCommand<string> NavigateToSIRSCommand { get; private set; }
        public MainWindowViewModel(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            NavigateCommand = new DelegateCommand<string>(Navigate);
            //NavigateToFTAECommand = new DelegateCommand<string>(ToFtae);
            //NavigateToSIRSCommand = new DelegateCommand<string>(ToSirs);
            //_regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(MTCO.InspectionMobileApp.ReferenceCentre.Views.MainPage));

            if (Properties.Settings.Default.IsEnglish || Properties.Settings.Default.IsFrench)
            {
                _regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(ReferenceCentre.Views.ReferenceCentre));
                _regionManager.RequestNavigate(RegionNames.MainRegion, new Uri("HomePage", UriKind.Relative));
            }
            else
            {
                _regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(ChooseLanguage));
            }

        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate(RegionNames.MainRegion, navigatePath);
        }
    }
}
