﻿using DataModelLibrary;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class EmployeeDashboardPage : BasePageObject, IEmployeeDashboard
    {       
    
     

        public void ClickFeedbackButton()
        {

            var locator =  SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleClickElement(locator);
        }

        public void ClickWhatsNewButton()
        {
            var locator = SetLocator(ElementType.Button, LocatorType.Id, "");

            HandleClickElement(locator);
        }
    }
}
