using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.WebElements;
using System;
using System.Collections.ObjectModel;

namespace SeleniumWebDriver.ConcreteClasses
{
   
    public class LocatorBuilder: SeleniumDriver, ILocatorBuilder
    {
        
        private static IWebElement _webElement;
        

        public LocatorBuilder(SeleniumConfiguration config) : base(config)
        {           
        }

        public IWebElement LocatorByIndex(BaseLocatorModel locator, int index, int waitTimeInSecs)
        {
            var locators = GetLocators(locator, waitTimeInSecs);

            return locators[index];
        }               

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillElementDisplayed(LocatorModel locator, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(waitTimeInSecs));

            return locator.BaseLocator.LocatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator.BaseLocator.Locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator.BaseLocator.Locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator.BaseLocator.Locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator.BaseLocator.Locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator.BaseLocator.Locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator.BaseLocator.Locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator.BaseLocator.Locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator.BaseLocator.Locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locator.BaseLocator.Locator}']"))),
                LocatorType.InputType => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"input='[{locator.BaseLocator.Locator}']"))),
                _ => throw new Exception($"LocatorType {locator.BaseLocator.LocatorType} is unknown."),
            };
        }

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillElementDisplayed(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(waitTimeInSecs));

            return locatorModel.LocatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorModel.Locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locatorModel.Locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locatorModel.Locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locatorModel.Locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorModel.Locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorModel.Locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locatorModel.Locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locatorModel.Locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"))),
                LocatorType.InputType => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"input='[{locatorModel.Locator}']"))),
                _ => throw new Exception($"LocatorType {locatorModel.LocatorType} is unknown."),
            };
        }

     

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>        

        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillDisplayed(BaseLocatorModel locator, int waitTimeInSecs)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(waitTimeInSecs));

            return locator.LocatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator.Locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator.Locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator.Locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator.Locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator.Locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator.Locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator.Locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator.Locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locator.Locator}']"))),
                LocatorType.InputType => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"input='[{locator.Locator}']"))),
                _ => throw new Exception($"LocatorType {locator.LocatorType} is unknown."),
            };
        }

        public IWebElement BuildLocator(BaseLocatorModel locatorModel, int waitTimeInSec = 10)
        {
            switch (locatorModel.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleById.FindElement(By.Id(locatorModel.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByClass.FindElement(By.ClassName(locatorModel.Locator));

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByCSS.FindElement(By.CssSelector(locatorModel.Locator));

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"));

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByLinkText.FindElement(By.LinkText(locatorModel.Locator));


                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locatorModel.Locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByTagName.FindElement(By.TagName(locatorModel.Locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByXPath.FindElement(By.XPath(locatorModel.Locator));

                case LocatorType.InputType:
                    var eleByInputType = _WaitTillDisplayed(locatorModel, waitTimeInSec);
                    return eleByInputType.FindElement(By.CssSelector($"input='[{locatorModel.Locator}']"));


                default:
                    return null;

            }
        }   

        public ReadOnlyCollection<IWebElement> GetLocators(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            switch (locator.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleById.FindElements(By.Id(locator.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByClass.FindElements(By.ClassName(locator.Locator));


                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByCSS.FindElements(By.CssSelector(locator.Locator));


                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locator.Locator}']"));


                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByLinkText.FindElements(By.LinkText(locator.Locator));

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locator.Locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByTagName.FindElements(By.TagName(locator.Locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByXPath.FindElements(By.XPath(locator.Locator));

                case LocatorType.InputType:
                    var eleByInputType = _WaitTillElementDisplayed(locator, waitTimeInSecs);
                    return eleByInputType.FindElements(By.CssSelector($"input='[{locator.Locator}']"));

                default:
                    return null;

            }
        }
    }
}
