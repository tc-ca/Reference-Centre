using Microsoft.Practices.Unity;
using NLog;
using Prism.Events;
using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using WPFLocalizeExtension.Engine;

namespace MTCO.InspectionMobileApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IEventAggregator _eventAggregator;
        public enum ApplicationExitCode
        {
            Success = 0,
            Failure = 1
        }

        private IUnityContainer container = new UnityContainer();
        private readonly Logger _logger = LogManager.GetLogger("App");
        public App()
        {
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
        }

        
        protected override void OnStartup(StartupEventArgs e)
        {

            Bootstrapper bs = new Bootstrapper();
            bs.Run();
            container = bs.Container;

            SetupLanguage();

            _eventAggregator = container.Resolve<IEventAggregator>();

            // UI Exceptions
            this.DispatcherUnhandledException += Application_DispatcherUnhandledException;
            // Thread exceptions
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            
            base.OnStartup(e);
        }

        private void SetupLanguage()
        {
            if (InspectionMobileApp.Properties.Settings.Default.IsEnglish)
            {
                LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("en-CA");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");
                FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                            XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
            }
            else if (MTCO.InspectionMobileApp.Properties.Settings.Default.IsFrench)
            {
                LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("fr-CA");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
                FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                            XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            }
            else
            {
                LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("en-CA");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-CA");
                FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                            XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            }
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            var exception = e.Exception;
            HandleUnhandledException(exception);
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            HandleUnhandledException(unhandledExceptionEventArgs.ExceptionObject as Exception);
            if (unhandledExceptionEventArgs.IsTerminating)
            {
                _logger.Info("Application is terminating due to an unhandled exception in a secondary thread.");
            }
        }

        private void HandleUnhandledException(Exception exception)
        {
            string message = "Unhandled exception";
            try
            {
                AssemblyName assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                message = string.Format("Unhandled exception in {0} v{1}", assemblyName.Name, assemblyName.Version);
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "Exception in unhandled exception handler");
            }
            finally
            {
                _logger.Error(exception, message);
            }
        }
    }
}
