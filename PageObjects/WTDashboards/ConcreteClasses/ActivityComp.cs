using DataModelLibrary;
using PageObjects.WTDashboards;
using SeleniumWebDriver;

namespace PageObjects.EmployeeDashboard.ConcreteClasses
{
    public class ActivityComp : BasePageObject, IActivityComp
    {
        public ActivityComp(IWebPage webPage) : base(webPage)
        {
        }

        public IActivityComp ClickCorrectionsTab()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            GetElement(locator).Click();            

            return this;
        }

        public IActivityComp ClickHistoryTab()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            GetElement(locator).Click();

            return this;
        }
    }
}
