using SeleniumWebDriver;
using SeleniumWebDriver.Type;
using PageObjects.WTDashboards.Models;
using System;

namespace PageObjects.SharedServices
{
    public class NavigationService :  INavigationService
    {
        private readonly IWebPage _webPage;
        public NavigationService(IWebPage webPage)           
        {
            _webPage = webPage;
        }


        public void NavigateToToggleMenuOpt(string menuOpt)
        {
            var toggleMenu = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "hamburgermenutoggle"
            };

            var menuItem = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = menuOpt
            };

            _webPage.ClickElement(toggleMenu.LocatorType, toggleMenu.Locator);
            _webPage.ClickElement(menuItem.LocatorType, menuItem.Locator);
        }

        public void OpenToWTEmployeeDashboard()
        {
            throw new NotImplementedException();
        }

        public void OpenToWTSupervisorDashboard()
        {
            throw new NotImplementedException();
        }
    }
}
