using DataModelLibrary;
using SeleniumWebDriver.ConcreteClasses;

namespace SeleniumWebDriver.WebElements
{
    public class Button : IButton
    {
        private LocatorBuilder LocatorBuilder => new LocatorBuilder();
        private readonly IDriverLogger _logger;

        public Button(IDriverLogger logger)
        {
            _logger = logger;
        }
      
        public void ClickButton(LocatorModel locatorModel)
        {
            _logger.Info("Clicking a Button");
            var element = LocatorBuilder.BuildLocator(locatorModel);
            element.Click();
        }       

        public string GetButtonText(LocatorModel locatorModel, int index = 0)
        {
            _logger.Info("Getting Button Text");
            if (index == 0)
            {
                var element = LocatorBuilder.BuildLocator(locatorModel);
                return element.Text;
            }
            else
            {
                var elements = LocatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Text;
            }
        }

        public bool IsButtonEnabled(LocatorModel locatorModel, int index = 0)
        {
            _logger.Info("Checking for Button being Enabled");

            if (index == 0)
            {
                var element = LocatorBuilder.BuildLocator(locatorModel);
                return element.Enabled;
            }
            else
            {
                var elements = LocatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Enabled;
            }
        }

       
        public bool IsButtonPresent(LocatorModel locatorModel, int index = 0)
        {

            _logger.Info("Checking that the Button is Present in the DOM");

            if (index == 0)
            {
                var element = LocatorBuilder.BuildLocator(locatorModel);
                return element.Displayed;
            }
            else
            {
                var elements = LocatorBuilder.LocatorByIndex(locatorModel, index);
                return elements.Displayed;
            }
        }
    }    
}
