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
       

        public void ClickOnRadioButton(LocatorModel locatorModel, int index = 0)
        {
            var isClicked = IsRadioButtonSelected(locatorModel);

            if (index == 0)
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel);
                    element.Click();
                }
            }
            else
            {
                if (!isClicked)
                {
                    var element = _locatorBuilder.LocatorByIndex(locatorModel, index);
                    element.Click();
                }
            }
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

        public bool IsRadioButtonEnabled(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            return element.Enabled;
        }

        public bool IsRadioButtonEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
            return element.Enabled;
        }

        public bool IsRadioButtonSelected(LocatorModel locatorModel)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return true;
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
