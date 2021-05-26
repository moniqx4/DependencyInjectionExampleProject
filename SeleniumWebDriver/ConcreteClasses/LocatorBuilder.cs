using DataModelLibrary;
using OpenQA.Selenium;
using SeleniumWebDriver.WebElements;
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumWebDriver.ConcreteClasses
{
   
    public class LocatorBuilder: ILocatorBuilder
    {
        [ThreadStatic]
        static IWebDriver _driver;

        private static IWebElement _webElement;
        

        public LocatorBuilder()
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
       
        private static IWebElement _WaitTillElementDisplayed(LocatorModel locator, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSecs));

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
        
        private static IWebElement _WaitTillElementDisplayed(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSecs));

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
       
        private static IWebElement _WaitTillDisplayed(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSecs));

            return locator.LocatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator.Locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locator.Locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locator.Locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementExists(By.LinkText(locator.Locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locator.Locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator.Locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locator.Locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator.Locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector($"[data-automation-id='{locator.Locator}']"))),
                LocatorType.InputType => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector($"input='[{locator.Locator}']"))),
                _ => throw new Exception($"LocatorType {locator.LocatorType} is unknown."),
            };
        }

        public IWebElement BuildLocator(BaseLocatorModel locatorModel, int waitTimeInSec = 10)
        {

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSec));

            switch (locatorModel.LocatorType)
            {
                case LocatorType.Id:                    
                    var eleById = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorModel.Locator)));
                    return eleById.FindElement(By.Id(locatorModel.Locator));

                case LocatorType.Class:
                    var eleByClass = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locatorModel.Locator)));
                    return eleByClass.FindElement(By.ClassName(locatorModel.Locator));

                case LocatorType.CSS:
                    var eleByCSS = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorModel.Locator)));
                    return eleByCSS.FindElement(By.CssSelector(locatorModel.Locator));

                case LocatorType.DataAutomationId:
                    var eleByDAID = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id={locatorModel.Locator}]")));
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"));

                case LocatorType.LinkText:
                    var eleByLinkText = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locatorModel.Locator)));
                    return eleByLinkText.FindElement(By.LinkText(locatorModel.Locator));

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locatorModel.Locator)));
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locatorModel.Locator));

                case LocatorType.TagName:
                    var eleByTagName = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locatorModel.Locator)));
                    return eleByTagName.FindElement(By.TagName(locatorModel.Locator));

                case LocatorType.XPath:
                    var eleByXPath = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorModel.Locator)));
                    return eleByXPath.FindElement(By.XPath(locatorModel.Locator));

                case LocatorType.InputType:
                    var eleByInputType = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"input='[{locatorModel.Locator}']")));
                    return eleByInputType.FindElement(By.CssSelector($"input='[{locatorModel.Locator}']"));


                default:
                    return null;

            }
        }   

        public ReadOnlyCollection<IWebElement> GetLocators(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSecs));

            switch (locator.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator.Locator)));
                    return eleById.FindElements(By.Id(locator.Locator));

                case LocatorType.Class:
                    var eleByClass = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator.Locator)));
                    return eleByClass.FindElements(By.ClassName(locator.Locator));


                case LocatorType.CSS:
                    var eleByCSS = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator.Locator)));
                    return eleByCSS.FindElements(By.CssSelector(locator.Locator));


                case LocatorType.DataAutomationId:
                    var eleByDAID = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locator.Locator}']")));
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locator.Locator}']"));


                case LocatorType.LinkText:
                    var eleByLinkText = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator.Locator)));
                    return eleByLinkText.FindElements(By.LinkText(locator.Locator));

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator.Locator)));
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locator.Locator));

                case LocatorType.TagName:
                    var eleByTagName = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator.Locator)));
                    return eleByTagName.FindElements(By.TagName(locator.Locator));

                case LocatorType.XPath:
                    var eleByXPath = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator.Locator)));
                    return eleByXPath.FindElements(By.XPath(locator.Locator));

                case LocatorType.InputType:
                    var eleByInputType = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"input='[{locator.Locator}']")));
                    return eleByInputType.FindElements(By.CssSelector($"input='[{locator.Locator}']"));

                default:
                    return null;

            }
        }
    }
}
