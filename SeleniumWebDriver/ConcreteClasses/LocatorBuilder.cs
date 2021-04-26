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


        public IWebElement BuildLocator(LocatorModel locatorModel)
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

        public IWebElement LocatorByIndex(LocatorModel locatorModel, int index)
        {
            var locators = GetLocators(locatorModel);

            return locators[index];
        }       

        public ReadOnlyCollection<IWebElement> GetLocators(LocatorModel locatorModel)
        {
            switch (locatorModel.LocatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locatorModel);
                    return eleById.FindElements(By.Id(locatorModel.Locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locatorModel);
                    return eleByClass.FindElements(By.ClassName(locatorModel.Locator));
               

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locatorModel);
                    return eleByCSS.FindElements(By.CssSelector(locatorModel.Locator));
              

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locatorModel);
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"));
               

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locatorModel);
                    return eleByLinkText.FindElements(By.LinkText(locatorModel.Locator));              

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locatorModel);
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locatorModel.Locator));             

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locatorModel);
                    return eleByTagName.FindElements(By.TagName(locatorModel.Locator));            

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locatorModel);
                    return eleByXPath.FindElements(By.XPath(locatorModel.Locator));              

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
        private static IWebElement _WaitTillElementDisplayed(LocatorModel locatorModel, int TimeOutForFindingElement = 10)
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
      
    }
}
