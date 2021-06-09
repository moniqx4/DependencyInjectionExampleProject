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

       
        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, bool isEnabled, int waitTimeInSecs = 10)
        {
            var isChecked = IsCheckboxChecked(locatorModel, waitTimeInSecs);
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);

            if (isEnabled)
            {                
                // checkbox is checked, but request is for it to not be checked, so clicking it to uncheck it
                if (!isChecked)
                {                    
                    element.Click();                    
                }
            } else
            {
                //does nothing because already in requested state
                return this;
            }


            if (!isEnabled)
            {
                // checkbox is not currently checked, but request is for it to be checked, so clicking checkbox
                if (isChecked)
                {
                    element.Click();
                    
                } else
                {
                    //does nothing because already in requested state
                    return this;
                }
            }

            return this;
            
        }

        public ICheckBox ClickCheckBox(BaseLocatorModel locatorModel, int timeInSecs = 10)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCheckboxChecked(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);

            if (element.GetAttribute("checked") != "checked")
            {
                return false;
            }
            else return true;

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

        public bool IsCheckboxEnabledByIndex(BaseLocatorModel locatorModel, int index, int timeInSecs = 10)
        {
            throw new System.NotImplementedException();
        }
    }
}
