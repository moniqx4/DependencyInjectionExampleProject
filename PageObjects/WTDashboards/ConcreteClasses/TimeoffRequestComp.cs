using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class TimeoffRequestComp : BasePageObject, ITimeOffComp
    {
        public TimeoffRequestComp(IWebPage webPage) : base(webPage)
        {
        }

        public ITimeOffComp ClickRequestTimeOffButton()
        {        

            var locator = SetLocator(LocatorType.DataAutomationId, "");

            var element = GetElement(locator);

            element.Click();

            return this;
            
        }

        public ITimeOffComp SetAvailabilityCheckbox(bool isEnabled)
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");           

            HandleCheckbox(locator, isEnabled);           

            return this;
        }

        public ITimeOffComp SetCommentsTextBox(string comments)
        {            

            var locator = SetLocator(LocatorType.DataAutomationId, "");

            var element = GetElement(locator);

            element.SendKeys(comments);

            return this;
        }

        public ITimeOffComp SetEndDateTextBox(string endDate)
        {
           
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            var element = GetElement(locator);

            element.SendKeys(endDate);

            return this;
        }

        public ITimeOffComp SetStartDateTextBox(string startDate)
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "");

            var element = GetElement(locator);

            element.SendKeys(startDate);

            return this;
        }
    }
}
