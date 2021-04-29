using DataModelLibrary;

namespace SeleniumWebDriver.WebElements
{
    public class Button : IButton
    {
        private ILocatorBuilder _locatorBuilder;
        private readonly IDriverLogger _logger;

        public Button(IDriverLogger logger, ILocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
            _logger = logger;
        }
      
        public void ClickButton(LocatorModel locatorModel)
        {
            _logger.Info("Clicking a Button");
            var element = _locatorBuilder.BuildLocator(locatorModel);
            element.Click();
        }       

        public string GetButtonText(LocatorModel locatorModel, int index = 0)
        {
            _logger.Info("Getting Button Text");
            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                return element.Text;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Text;
            }
        }

        public bool IsButtonEnabled(LocatorModel locatorModel, int index = 0)
        {
            _logger.Info("Checking for Button being Enabled");

            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                return element.Enabled;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Enabled;
            }
        }

       
        public bool IsButtonPresent(LocatorModel locatorModel, int index = 0)
        {

            _logger.Info("Checking that the Button is Present in the DOM");

            if (index == 0)
            {
                var element = _locatorBuilder.BuildLocator(locatorModel);
                return element.Displayed;
            }
            else
            {
                var elements = _locatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Displayed;
            }
        }

        public bool IsButtonEnabled(BaseLocatorModel locator, int index = 0)
        {
            throw new System.NotImplementedException();
        }

        public string GetButtonText(BaseLocatorModel locator, int index = 0)
        {
            throw new System.NotImplementedException();
        }

        public bool IsButtonPresent(BaseLocatorModel locator, int index = 0)
        {
            throw new System.NotImplementedException();
        }

        public void ClickButton(BaseLocatorModel locator)
        {
            throw new System.NotImplementedException();
        }
    }    
}
