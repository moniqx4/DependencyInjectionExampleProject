using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class EmployeeDashboardPage : BasePageObject, IEmployeeDashboardPage
    {
        public EmployeeDashboardPage(IWebPage webPage) : base(webPage)
        {
        }

        public void ClickFeedbackButton()
        {

            var locator =  SetLocator(LocatorType.Id, "");

            GetElement(locator).Click();
        }

        public void ClickWhatsNewButton()
        {
            var locator = SetLocator(LocatorType.Id, "");

            GetElement(locator).Click();
        }
    }
}
