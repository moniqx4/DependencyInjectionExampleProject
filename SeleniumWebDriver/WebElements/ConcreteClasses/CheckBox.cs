using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class CheckBox : ICheckBox
    {
        private readonly ILocatorBuilder _locatorBuilder;

        public CheckBox(ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
       

        public ICheckBox ClickCheckBox(LocatorModel locatorModel)
        {
            var isChecked = IsCheckboxChecked(locatorModel);

            if (!isChecked)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                element.Click();
            }

            return this;
        }

        public ICheckBox ClickCheckBox(LocatorModel locatorModel, bool isEnabled)
        {
            var isChecked = IsCheckboxChecked(locatorModel);

            if (isEnabled)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel);
                    element.Click();
                }
            }
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel);
                    element.Click();
                }
            }

            return this;
        }

        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, int timeInSecs = 10)
        {
            var isChecked = IsCheckboxChecked(locatorModel, timeInSecs);

            if (isChecked)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, timeInSecs);
                    element.Click();
                }
            }
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, timeInSecs);
                    element.Click();
                }
            }

            return this;
        }

        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, bool isEnabled, int timeInSecs = 10)
        {
            var isChecked = IsCheckboxChecked(locatorModel, timeInSecs);

            if (isEnabled)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, timeInSecs);
                    element.Click();
                }
            }
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, timeInSecs);
                    element.Click();
                }
            }

            return this;
        }

        public bool IsCheckboxChecked(LocatorModel locator)
        {
            var element = _locatorBuilder.BuildLocator(locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            else
                return true;
        }

        public bool IsCheckboxChecked(BaseLocatorModel locatorModel, int timeInSecs = 10)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCheckboxEnabled(LocatorModel locatorModel)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCheckboxEnabled(BaseLocatorModel locatorModel, int timeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, timeInSecs);
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            else
                return true;
        }

        /* ----- Multiple locators methods TODO-----*/
    }
}
