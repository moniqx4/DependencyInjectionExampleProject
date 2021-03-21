using SeleniumWebDriver;
using SeleniumWebDriver.Type;
using PageObjects.WTDashboards.Models;
using System;

namespace PageObjects.SharedServices
{
    public class NavigationService :  INavigationService
    {
        private readonly IWebPage _webPage;
        private readonly IBrowser _browser;
        public NavigationService(IWebPage webPage, IBrowser browser)
        {
            _webPage = webPage;
            _browser = browser;
        }
   

        public void NavigateViaSideMenu(string menuOption)
        {
            var toggleMenu = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "hamburgermenutoggle",
                ElementType = ElementType.Link
            };

            var menuItem = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = menuOption,
                ElementType = ElementType.Option
            };

            _webPage.ClickElement(toggleMenu.LocatorType, toggleMenu.Locator, toggleMenu.ElementType);
            _webPage.ClickElement(menuItem.LocatorType, menuItem.Locator, ElementType.Option);
        }

        public void NavigateViaUrl(string baseUrl, string path)
        {            
            _browser.NavigateTo(baseUrl + path);
        }

        public void NavigateViaWTTopMenu(string topMenuLocator, string menuOption = null)
        {
            var topMenu = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = topMenuLocator,
                ElementType = ElementType.Link
            };

            _webPage.ClickElement(topMenu.LocatorType, topMenu.Locator, topMenu.ElementType);

            if (menuOption != null)
            {
                var menuItem = new LocatorModel()
                {
                    LocatorType = LocatorType.DataAutomationId,
                    Locator = menuOption,
                    ElementType = ElementType.Option
                };

                _webPage.ClickElement(menuItem.LocatorType, menuItem.Locator, menuItem.ElementType);
            }
           
        }

        public void OpenToWebKioskAdminLoginPage(string baseUrl)
        {
            var adminLoginPath = "";
            _browser.NavigateTo(baseUrl + adminLoginPath);
        }

        public void OpenToWebKioskLoginPage(string baseUrl)
        {            
            var webKioskLoginPath = "";
            _browser.NavigateTo(baseUrl + webKioskLoginPath);
        }

        public void OpenToWTEmployeeDashboard(string baseUrl)
        {
            var eedpath = "";
            _browser.NavigateTo(baseUrl + eedpath);
        }

        public void OpenToWTSupervisorDashboard(string baseUrl)
        {
            var sdbpath = "";
            _browser.NavigateTo(baseUrl + sdbpath);
        }
    }
}
