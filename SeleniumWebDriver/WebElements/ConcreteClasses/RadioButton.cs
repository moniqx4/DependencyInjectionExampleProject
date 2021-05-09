using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class RadioButton : IRadioButton
    {
        private readonly ILocatorBuilder _locatorBuilder;
        public RadioButton(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }       

        public void ClickOnRadioButton(BaseLocatorModel locatorModel, int index = 0, int waitTimeInSecs = 10)
        {
            var isClicked = IsRadioButtonSelected(locatorModel, waitTimeInSecs);

            if (index == 0)
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                    element.Click();
                }
            }
            else
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.LocatorByIndex(locatorModel, index, waitTimeInSecs);
                    element.Click();
                }
            }
        }
     

        public bool IsRadioButtonEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Enabled;
        }
     

        public bool IsRadioButtonSelected(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return true;
        }
    }
}
