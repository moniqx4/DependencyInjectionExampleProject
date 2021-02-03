using DependencyInjectionExampleProject.PageObjects;
using SeleniumWebDriver;
using System;

namespace PageObjects.SharedServices
{
    public class NavigationService :  PageObjectBase, INavigationService
    {
        private readonly IWebPage _webPage;
        public NavigationService(DriverContext driverContext, IWebPage webPage)
            : base(driverContext)
        {
            _webPage = webPage;
        }


        public void NavigateToToggleMenuOpt(string menuOpt)
        {
           
            throw new NotImplementedException();
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
