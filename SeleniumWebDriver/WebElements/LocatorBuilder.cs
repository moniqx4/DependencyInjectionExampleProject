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

        public IWebElement BuildLocator(LocatorType locatorType, string locator)
        {
            switch (locatorType)
            {
                case LocatorType.Id:
                    return _driver.FindElement(By.Id(locator));

                case LocatorType.Class:
                    return _driver.FindElement(By.ClassName(locator));

                case LocatorType.CSS:
                    return _driver.FindElement(By.CssSelector(locator));

                case LocatorType.DataAutomationId:
                    return _driver.FindElement(By.CssSelector($"[data-automation-id='{locator}']"));

                case LocatorType.LinkText:
                    return _driver.FindElement(By.LinkText(locator));

                case LocatorType.PartialLinkText:
                    return _driver.FindElement(By.PartialLinkText(locator));

                case LocatorType.TagName:
                    return _driver.FindElement(By.TagName(locator));

                case LocatorType.XPath:
                    return _driver.FindElement(By.XPath(locator));

                default:
                    return null;

            }
        }
    }
}
