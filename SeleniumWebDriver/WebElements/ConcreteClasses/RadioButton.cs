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

        public bool IsRadioButtonEnabled(LocatorModel locatorModel)
        {
            throw new System.NotImplementedException();
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
    }
}
