using DependencyInjectionExampleProject.PageObjects.WTDashboards;
using SeleniumWebDriver;
using SeleniumWebDriver.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.SharedServices
{
    public class NavigationService :  PageObjectBase, INavigationService
    {

        public NavigationService(DriverContext driverContext)
            : base(driverContext)
        {
        }


        public void NavigateToToggleMenuOpt(string menuOpt)
        {
            
            Driver.FindElement(by.)
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
