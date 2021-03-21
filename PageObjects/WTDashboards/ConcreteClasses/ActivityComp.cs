using PageObjects.WTDashboards;
using PageObjects.WTDashboards.Models;
using SeleniumWebDriver;
using SeleniumWebDriver.Type;

namespace PageObjects.EmployeeDashboard.ConcreteClasses
{
    public class ActivityComp : IActivityComp
    {
        private readonly IWebPage _webPage;
        public ActivityComp(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IActivityComp ClickCorrectionsTab()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Tab
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);

            return this;
        }

        public IActivityComp ClickHistoryTab()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Tab
            };

            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);

            return this;
        }
    }
}
