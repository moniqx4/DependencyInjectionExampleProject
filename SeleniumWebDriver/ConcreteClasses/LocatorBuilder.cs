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


        public IWebElement BuildLocator(LocatorModel locator)
        {
            switch (locator.BaseLocator.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator);
                    return eleById.FindElement(By.Id(locator.BaseLocator.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator);
                    return eleByClass.FindElement(By.ClassName(locator.BaseLocator.Locator));              

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator);
                    return eleByCSS.FindElement(By.CssSelector(locator.BaseLocator.Locator));              

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locator.BaseLocator.Locator}']"));               

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator);
                    return eleByLinkText.FindElement(By.LinkText(locator.BaseLocator.Locator));
                

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locator.BaseLocator.Locator));
               
                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator);
                    return eleByTagName.FindElement(By.TagName(locator.BaseLocator.Locator));
               
                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator);
                    return eleByXPath.FindElement(By.XPath(locator.BaseLocator.Locator));
               

                default:
                    return null;

            }
        }

        public IWebElement LocatorByIndex(LocatorModel locator, int index)
        {
            var locators = GetLocators(locator);

            return locators[index];
        }       

        public ReadOnlyCollection<IWebElement> GetLocators(LocatorModel locator)
        {
            switch (locator.BaseLocator.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator);
                    return eleById.FindElements(By.Id(locator.BaseLocator.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator);
                    return eleByClass.FindElements(By.ClassName(locator.BaseLocator.Locator));
               

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator);
                    return eleByCSS.FindElements(By.CssSelector(locator.BaseLocator.Locator));
              

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator);
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locator.BaseLocator.Locator}']"));
               

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator);
                    return eleByLinkText.FindElements(By.LinkText(locator.BaseLocator.Locator));              

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator);
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locator.BaseLocator.Locator));             

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator);
                    return eleByTagName.FindElements(By.TagName(locator.BaseLocator.Locator));            

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator);
                    return eleByXPath.FindElements(By.XPath(locator.BaseLocator.Locator));              

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
        private static IWebElement _WaitTillElementDisplayed(LocatorModel locator, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

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
        private static IWebElement _WaitTillElementDisplayed(BaseLocatorModel locatorModel, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

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
                _ => throw new Exception($"LocatorType {locatorModel.LocatorType} is unknown."),
            };
        }

        public IWebElement BuildLocator(BaseLocatorModel locatorModel)
        {

            switch (locatorModel.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locatorModel);
                    return eleById.FindElement(By.Id(locatorModel.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locatorModel);
                    return eleByClass.FindElement(By.ClassName(locatorModel.Locator));

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locatorModel);
                    return eleByCSS.FindElement(By.CssSelector(locatorModel.Locator));

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locatorModel);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"));

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locatorModel);
                    return eleByLinkText.FindElement(By.LinkText(locatorModel.Locator));


                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locatorModel);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locatorModel.Locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locatorModel);
                    return eleByTagName.FindElement(By.TagName(locatorModel.Locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locatorModel);
                    return eleByXPath.FindElement(By.XPath(locatorModel.Locator));


                default:
                    return null;

            }
        }

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>        

        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        private static IWebElement _WaitTillDisplayed(BaseLocatorModel locator, int timeInSec)
        {
            var wait = new WebDriverWait(_browser, TimeSpan.FromSeconds(timeInSec));

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
                _ => throw new Exception($"LocatorType {locator.LocatorType} is unknown."),
            };
        }

        public IWebElement BuildLocator(BaseLocatorModel locatorModel, int timeInSec = 10)
        {
            switch (locatorModel.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleById.FindElement(By.Id(locatorModel.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByClass.FindElement(By.ClassName(locatorModel.Locator));

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByCSS.FindElement(By.CssSelector(locatorModel.Locator));

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"));

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByLinkText.FindElement(By.LinkText(locatorModel.Locator));


                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locatorModel.Locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByTagName.FindElement(By.TagName(locatorModel.Locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillDisplayed(locatorModel, timeInSec);
                    return eleByXPath.FindElement(By.XPath(locatorModel.Locator));


                default:
                    return null;

            }
        }

        public IWebElement LocatorByIndex(BaseLocatorModel locator, int index, int timeInSec = 10)
        {
            var locators = GetLocators(locator);

            return locators[index];
        }

        public ReadOnlyCollection<IWebElement> GetLocators(BaseLocatorModel locator, int timeInSec = 10)
        {
            switch (locator.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator);
                    return eleById.FindElements(By.Id(locator.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator);
                    return eleByClass.FindElements(By.ClassName(locator.Locator));


                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator);
                    return eleByCSS.FindElements(By.CssSelector(locator.Locator));


                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator);
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locator.Locator}']"));


                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator);
                    return eleByLinkText.FindElements(By.LinkText(locator.Locator));

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator);
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locator.Locator));

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator);
                    return eleByTagName.FindElements(By.TagName(locator.Locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator);
                    return eleByXPath.FindElements(By.XPath(locator.Locator));

                default:
                    return null;

            }
        }
    }
}
