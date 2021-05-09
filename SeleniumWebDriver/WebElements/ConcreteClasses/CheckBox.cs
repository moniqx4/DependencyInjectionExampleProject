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

       
        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var isChecked = IsCheckboxChecked(locatorModel, waitTimeInSecs);

            if (isChecked)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                    element.Click();
                }
            }
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                    element.Click();
                }
            }

            return this;
        }

        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, bool isEnabled, int waitTimeInSecs = 10)
        {
            var isChecked = IsCheckboxChecked(locatorModel, waitTimeInSecs);

            if (isEnabled)
            {
                if (!isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                    element.Click();
                }
            }
            else
            {
                if (isChecked)
                {
                    var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
                    element.Click();
                }
            }

            return this;
        }
     
        public bool IsCheckboxChecked(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCheckboxEnabled(LocatorModel locatorModel)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCheckboxEnabled(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);
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
