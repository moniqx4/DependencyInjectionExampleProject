using OpenQA.Selenium;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class LocatorBuilder
    {        
        static IWebElement _driver;

        public LocatorBuilder()
        {

        }

        public IWebElement BuildLocator(Locator locatorType, string locator)
        {
            switch (locatorType)
            {
                case Locator.Id:
                    return _driver.FindElement(By.Id(locator));

                case Locator.Class:
                    return _driver.FindElement(By.ClassName(locator));

                case Locator.CSS:
                    return _driver.FindElement(By.CssSelector(locator));

                case Locator.DataAutomationId:
                    return _driver.FindElement(By.CssSelector($"[data-automation-id='{locator}']"));

                case Locator.LinkText:
                    return _driver.FindElement(By.LinkText(locator));

                case Locator.PartialLinkText:
                    return _driver.FindElement(By.PartialLinkText(locator));

                case Locator.TagName:
                    return _driver.FindElement(By.TagName(locator));

                case Locator.XPath:
                    return _driver.FindElement(By.XPath(locator));

                default:
                    return null;

            }
        }
    }
}
