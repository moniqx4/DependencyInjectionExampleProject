using DataModelLibrary;
using AutomationServices.SharedServices.BrowserActions;
using AutomationServices.SharedServices.ElementActions;

namespace PageObjects.SharedServices
{
    public class NavigationService :  INavigationService
    {
        
        private readonly IBrowserActions _browser;
        private readonly IElementActions _element;

        public NavigationService(IBrowserActions browser, IElementActions element)
        {           
            _browser = browser;
            _element = element;
        }


        public void NavigateViaSideMenu(string menuOption)
        {  
            _element.ClickElement(LocatorType.DataAutomationId, "hamburgermenutoggle");
            _element.ClickElement(LocatorType.DataAutomationId, menuOption);           
        }

        public void NavigateViaUrl(string baseUrl, string path)
        {            
            _browser.NavigateToPageUrl(baseUrl + path);
        }

        public void NavigateViaWTTopMenu(string topMenuLocator, string menuOption = null)
        {
            
            _element.ClickElement(LocatorType.DataAutomationId, topMenuLocator);           

            if (menuOption != null)
            {
                _element.ClickElement(LocatorType.DataAutomationId, menuOption);
            }
           
        }

        public void OpenToWebKioskAdminLoginPage(string baseUrl)
        {
            var adminLoginPath = "";
            _browser.NavigateToPageUrl(baseUrl + adminLoginPath);
        }

        public void OpenToWebKioskLoginPage(string baseUrl)
        {            
            var webKioskLoginPath = "";
            _browser.NavigateToPageUrl(baseUrl + webKioskLoginPath);
        }

        public void OpenToWTEmployeeDashboard(string baseUrl)
        {
            var eedpath = "";
            _browser.NavigateToPageUrl(baseUrl + eedpath);
        }

        public void OpenToWTSupervisorDashboard(string baseUrl)
        {
            var sdbpath = "";
            _browser.NavigateToPageUrl(baseUrl + sdbpath);
        }
    }
}
