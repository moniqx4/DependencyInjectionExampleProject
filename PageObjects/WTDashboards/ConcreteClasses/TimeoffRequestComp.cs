using DataModelLibrary;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class TimeoffRequestComp : BasePageObject, ITimeOffComp
    {
      
        public ITimeOffComp ClickRequestTimeOffButton()
        {
            var locatorModel = new BaseLocatorModel()
            {             
                    LocatorType = LocatorType.DataAutomationId,
                    Locator = ""
               
            };

            HandleClickElement(locatorModel);

            return this;
        }

        public ITimeOffComp SetAvailabilityCheckbox(bool isEnabled)
        {
            var locatorModel = new BaseLocatorModel()
            {               
                    LocatorType = LocatorType.Id,
                    Locator = ""              
            };

            HandleCheckbox(locatorModel, isEnabled);           

            return this;
        }

        public ITimeOffComp SetCommentsTextBox(string comments)
        {
            var locator = new BaseLocatorModel()
            {
                    LocatorType = LocatorType.Id,
                    Locator = ""
             
            };

            SetTextBox(locator, comments);

            return this;
        }

        public ITimeOffComp SetEndDateTextBox(string endDate)
        {
            var locator = new BaseLocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = ""

            };

            SetTextBox(locator, endDate);

            return this;
        }

        public ITimeOffComp SetStartDateTextBox(string startDate)
        {
            var locator = new BaseLocatorModel()
            {
                LocatorType = LocatorType.Id,
                Locator = ""

            };

            SetTextBox(locator, startDate);

            return this;
        }
    }
}
