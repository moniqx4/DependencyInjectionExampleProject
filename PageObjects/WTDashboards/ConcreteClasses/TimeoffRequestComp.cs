using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class TimeoffRequestComp : ITimeOffComp
    {
        private readonly IWebPage _webPage;
       

        public TimeoffRequestComp(IWebPage webPage)
        {          
            _webPage = webPage;
        }
        public ITimeOffComp ClickRequestTimeOffButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Button
            };
           
            _webPage.ClickElement(locatorModel.LocatorType, locatorModel.Locator, locatorModel.ElementType);

            return this;
        }

        public ITimeOffComp SetAvailabilityCheckbox(bool isEnabled)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Checkbox
            };
            
            _webPage.CheckCheckbox(locatorModel.LocatorType, locatorModel.Locator, isEnabled);

            return this;
        }

        public ITimeOffComp SetCommentsTextBox(string comments)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Checkbox
            };

            _webPage.SetText(locatorModel.LocatorType, locatorModel.Locator, comments);

            return this;
        }

        public ITimeOffComp SetEndDateTextBox(string endDate)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Checkbox
            };

           _webPage.SetText(locatorModel.LocatorType, locatorModel.Locator, endDate);

            return this;
        }

        public ITimeOffComp SetStartDateTextBox(string startDate)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "",
                ElementType = ElementType.Checkbox
            };

            _webPage.SetText(locatorModel.LocatorType, locatorModel.Locator, startDate);

            return this;
        }
    }
}
