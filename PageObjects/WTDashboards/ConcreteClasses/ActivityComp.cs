using DataModelLibrary;
using PageObjects.WTDashboards;
using SeleniumWebDriver;

namespace PageObjects.EmployeeDashboard.ConcreteClasses
{
    public class ActivityComp : BasePageObject, IActivityComp
    {
        private readonly IWebPage _webPage;
        public ActivityComp(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IActivityComp ClickCorrectionsTab()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            HandleClickElement(locator);

            return this;
        }

        public IActivityComp ClickHistoryTab()
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            HandleClickElement(locator);           

            return this;
        }
    }
}
