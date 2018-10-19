using MTCO.InspectionMobileApp.Common;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Input;
using WPFLocalizeExtension.Engine;

namespace MTCO.InspectionMobileApp.ViewModels
{
    public class ChooseLanguageViewModel : BindableBase, INavigationAware
    {
        IRegionManager _regionManager;
        public ICommand EnglishCommand { get { return new DelegateCommand(English); } }

        private void English()
        {
            ChooseLanguage();
        }

        public ICommand FrenchCommand
        {
            get
            {
                return new DelegateCommand(French);
            }
        }

        private void French()
        {
            ChooseLanguage(false);
        }

        private void ChooseLanguage(bool isEnglish = true)
        {
            Configuration oConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (isEnglish)
            {
                Properties.Settings.Default.IsEnglish = true;
                LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("en-CA");
            }
            else
            {
                Properties.Settings.Default.IsFrench = true;
                LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("fr-CA");
            }

            //oConfig.Save(ConfigurationSaveMode.Full);
            //ConfigurationManager.RefreshSection("appSettings");
            MTCO.InspectionMobileApp.Properties.Settings.Default.Save();
            this._regionManager.RequestNavigate(RegionNames.MainRegion, new Uri("RCMainPage", UriKind.Relative));
        }

        public ChooseLanguageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;                                          
        }

        #region Navigation
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        #endregion
    }
}