using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Type;
using System;

namespace SeleniumWebDriver.WebElements
{
    public class LocatorBuilder
    {
        //[ThreadStatic]
        //static IWebElement _driver;

        private static IWebElement _webElement;

        public LocatorBuilder()
        {

        }

        public IWebElement BuildLocator(LocatorType locatorType, string locator)
        {
            switch (locatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator, locatorType);
                    return eleById.FindElement(By.Id(locator));                   

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByClass.FindElement(By.ClassName(locator));
                    //return _driver.FindElement(By.ClassName(locator));

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByCSS.FindElement(By.CssSelector(locator));
                    //return _driver.FindElement(By.CssSelector(locator));

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locator}']"));
                    //return _driver.FindElement(By.CssSelector($"[data-automation-id='{locator}']"));

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByLinkText.FindElement(By.LinkText(locator));
                    //return _driver.FindElement(By.LinkText(locator));

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locator));
                    //return _driver.FindElement(By.PartialLinkText(locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByTagName.FindElement(By.TagName(locator));
                    //return _driver.FindElement(By.TagName(locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByXPath.FindElement(By.XPath(locator));
                    //return _driver.FindElement(By.XPath(locator));

                default:
                    return null;

            }
        }


        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillElementExist(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            switch (locatorType)
            {
                case LocatorType.XPath:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));

                case LocatorType.PartialLinkText:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locator)));

                case LocatorType.Name:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locator)));

                case LocatorType.LinkText:
                    return wait.Until(ExpectedConditions.ElementExists(By.LinkText(locator)));

                case LocatorType.Id:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locator)));

                case LocatorType.CSS:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator)));

                case LocatorType.TagName: 
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locator)));

                case LocatorType.Class:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator)));

                case LocatorType.DataAutomationId:
                    return _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector($"[data-automation-id='{locator}']")));

                default:
                    throw new Exception($"LocatorType {locatorType} is unknown.");
            }
        }

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillElementDisplayed(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            switch (locatorType)
            {
                case LocatorType.XPath:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));

                case LocatorType.PartialLinkText:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));

                case LocatorType.Name:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));

                case LocatorType.LinkText:
                    return wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));

                case LocatorType.Id:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));

                case LocatorType.CSS:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));

                case LocatorType.TagName:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));

                case LocatorType.Class:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));

                case LocatorType.DataAutomationId:
                    return _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locator}']")));

                default:
                    throw new Exception($"LocatorType {locatorType} is unknown.");
            }
        }

        /// <summary>
        /// Create a instance of Selenium webElement when element staleness is gone 
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        [Obsolete]
        public static void WaitTillElementStalenessOf(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            switch (locatorType)
            {
                case LocatorType.XPath:                   
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.XPath(locator))));
                    break;

                case LocatorType.PartialLinkText:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.PartialLinkText(locator))));
                    break;

                case LocatorType.Name:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Name(locator))));
                    break;

                case LocatorType.LinkText:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.LinkText(locator))));
                    break;

                case LocatorType.Id:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Id(locator))));
                    break;

                case LocatorType.CSS:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.CssSelector(locator))));
                    break;

                case LocatorType.TagName:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.TagName(locator))));
                    break;

                case LocatorType.Class:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.ClassName(locator))));
                    break;

                case LocatorType.DataAutomationId:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.CssSelector($"[data-automation-id='{locator}']"))));
                    break;

                default:
                    throw new Exception($"LocatorType {locatorType} is unknown.");
            }

        }
    }

}
