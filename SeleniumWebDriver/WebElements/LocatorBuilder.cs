using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

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

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByCSS.FindElement(By.CssSelector(locator));                  

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByDAID.FindElement(By.CssSelector($"[data-automation-id='{locator}']"));                   

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByLinkText.FindElement(By.LinkText(locator));                 

                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByPartialLinkText.FindElement(By.PartialLinkText(locator));               

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByTagName.FindElement(By.TagName(locator));

                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByXPath.FindElement(By.XPath(locator));                 

                default:
                    return null;

            }
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

        /// <summary>
        /// Use this method with the locator being used returns more than 1 locator
        /// </summary>
        /// <param name="locatorType">Type of Locator</param>
        /// <param name="locator">actual locator</param>
        /// <param name="index">starting with 0, enter in the index of the locator you want to use</param>
        /// <returns>Returns one specified locator based on the index of locator in collection </returns>
        public IWebElement LocatorByIndex(LocatorType locatorType, string locator, int index)
        {
            var locators = GetLocators(locatorType, locator);

            return locators[index];
        }

        public IWebElement LocatorByIndex(LocatorModel locatorModel, int index)
        {
            var locators = GetLocators(locatorModel);

            return locators[index];
        }

        public ReadOnlyCollection<IWebElement> GetLocators(LocatorType locatorType, string locator)
        {
            switch (locatorType)
            {
                case LocatorType.Id:
                    var eleById = _WaitTillElementDisplayed(locator, locatorType);
                    return eleById.FindElements(By.Id(locator));

                case LocatorType.Class:
                    var eleByClass = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByClass.FindElements(By.ClassName(locator));              

                case LocatorType.CSS:
                    var eleByCSS = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByCSS.FindElements(By.CssSelector(locator));          

                case LocatorType.DataAutomationId:
                    var eleByDAID = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByDAID.FindElements(By.CssSelector($"[data-automation-id='{locator}']"));            

                case LocatorType.LinkText:
                    var eleByLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByLinkText.FindElements(By.LinkText(locator));
           
                case LocatorType.PartialLinkText:
                    var eleByPartialLinkText = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByPartialLinkText.FindElements(By.PartialLinkText(locator));         

                case LocatorType.TagName:
                    var eleByTagName = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByTagName.FindElements(By.TagName(locator));
           
                case LocatorType.XPath:
                    var eleByXPath = _WaitTillElementDisplayed(locator, locatorType);
                    return eleByXPath.FindElements(By.XPath(locator));            

                default:
                    return null;

            }

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
        private static IWebElement _WaitTillElementExist(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            return locatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementExists(By.LinkText(locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector($"[data-automation-id='{locator}']"))),
                _ => throw new Exception($"LocatorType {locatorType} is unknown."),
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
        private static IWebElement _WaitTillElementExist(LocatorModel locatorModel, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            return locatorModel.LocatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locatorModel.Locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locatorModel.Locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locatorModel.Locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementExists(By.LinkText(locatorModel.Locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locatorModel.Locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locatorModel.Locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locatorModel.Locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locatorModel.Locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"))),
                _ => throw new Exception($"LocatorType {locatorModel.LocatorType} is unknown."),
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
        private static IWebElement _WaitTillElementDisplayed(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            return locatorType switch
            {
                LocatorType.XPath => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator))),
                LocatorType.PartialLinkText => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator))),
                LocatorType.Name => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator))),
                LocatorType.LinkText => wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator))),
                LocatorType.Id => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator))),
                LocatorType.CSS => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator))),
                LocatorType.TagName => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator))),
                LocatorType.Class => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator))),
                LocatorType.DataAutomationId => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[data-automation-id='{locator}']"))),
                _ => throw new Exception($"LocatorType {locatorType} is unknown."),
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
        private static IWebElement _WaitTillElementDisplayed(LocatorModel locatorModel, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

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

        /// <summary>
        /// Create a instance of Selenium webElement when element staleness is gone 
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        [Obsolete]
        public static void WaitTillElementStalenessOf(LocatorModel locatorModel, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            switch (locatorModel.LocatorType)
            {
                case LocatorType.XPath:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.XPath(locatorModel.Locator))));
                    break;

                case LocatorType.PartialLinkText:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.PartialLinkText(locatorModel.Locator))));
                    break;

                case LocatorType.Name:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Name(locatorModel.Locator))));
                    break;

                case LocatorType.LinkText:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.LinkText(locatorModel.Locator))));
                    break;

                case LocatorType.Id:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Id(locatorModel.Locator))));
                    break;

                case LocatorType.CSS:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.CssSelector(locatorModel.Locator))));
                    break;

                case LocatorType.TagName:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.TagName(locatorModel.Locator))));
                    break;

                case LocatorType.Class:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.ClassName(locatorModel.Locator))));
                    break;

                case LocatorType.DataAutomationId:
                    wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.CssSelector($"[data-automation-id='{locatorModel.Locator}']"))));
                    break;

                default:
                    throw new Exception($"LocatorType {locatorModel.LocatorType} is unknown.");
            }

        }
    }

}
