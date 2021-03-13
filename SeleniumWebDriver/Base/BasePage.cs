using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;
using System;

namespace SeleniumWebDriver.Base
{
    public class BasePage
    {
        /// <summary>
        /// Helper Componnents object
        /// </summary>
        public Helpers Helper = new Helpers();
        private static IWebElement _webElement;

        public BasePage(IWebDriver driver)
        {
            SeleniumDriver.Browser = driver;
        }

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        public static IWebElement WaitTillElementExist(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            if (locatorType == LocatorType.XPath)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
            }
            else if (locatorType == LocatorType.PartialLinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locator)));
            }
            else if (locatorType == LocatorType.Name)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locator)));
            }
            else if (locatorType == LocatorType.LinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.LinkText(locator)));
            }
            else if (locatorType == LocatorType.Id)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locator)));
            }
            else if (locatorType == LocatorType.CSS)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator)));
            }
            else if (locatorType == LocatorType.TagName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locator)));
            }
            else if (locatorType == LocatorType.Class)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator)));
            }

            return _webElement;
        }

        /// <summary>
        /// Create a instance of Selenium webElement
        /// </summary>
        /// <param name="locator">Locator path</param>
        /// <param name="locatorType"> Locator Type i.e. Xpath,Id,etc.</param>
        /// <param name="TimeOutForFindingElement"> Number of seconds an element should wait for a webelement to display or exists </param>
        /// <returns> an instance of the webelement</returns>
        [Obsolete]
        public static IWebElement WaitTillElementDisplayed(string locator, LocatorType locatorType = LocatorType.XPath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(SeleniumDriver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            if (locatorType == LocatorType.XPath)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            else if (locatorType == LocatorType.PartialLinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
            }
            else if (locatorType == LocatorType.Name)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
            }
            else if (locatorType == LocatorType.LinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
            }
            else if (locatorType == LocatorType.Id)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
            }
            else if (locatorType == LocatorType.CSS)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
            }
            else if (locatorType == LocatorType.TagName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
            }
            else if (locatorType == LocatorType.Class)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
            }

            return _webElement;
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

            if (locatorType == LocatorType.XPath)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.XPath(locator))));
            }
            else if (locatorType == LocatorType.PartialLinkText)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.PartialLinkText(locator))));
            }
            else if (locatorType == LocatorType.Name)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Name(locator))));
            }
            else if (locatorType == LocatorType.LinkText)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.LinkText(locator))));
            }
            else if (locatorType == LocatorType.Id)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.Id(locator))));
            }
            else if (locatorType == LocatorType.CSS)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.CssSelector(locator))));
            }
            else if (locatorType == LocatorType.TagName)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.TagName(locator))));
            }
            else if (locatorType == LocatorType.Class)
            {
                wait.Until(ExpectedConditions.StalenessOf(SeleniumDriver.Browser.FindElement(By.ClassName(locator))));
            }
        }
    }

    /// <summary>
    ///  Helper Components 
    /// </summary>
    public class Helpers
    {
        /// <summary>
        /// Auto suggest Helper components
        /// </summary>
        public AutoTextComplete AutoTextComplete = new AutoTextComplete();

        /// <summary>
        /// Mouse Action Helper components  
        /// </summary>
        public MouseActions MouseActions = new MouseActions();

        /// <summary>
        /// KeyBoard Action Helper components 
        /// </summary>
        public KeyboardInteractions KeyBoardInteractions = new KeyboardInteractions();

        /// <summary>
        /// Browser Helper Components 
        /// </summary>
        public Browser Browser = new Browser();

        /// <summary>
        /// All Button Helper Component
        /// </summary>
        public Button Button = new Button();

        /// <summary>
        /// CheckBox Helper Components
        /// </summary>
        public CheckBox CheckBox = new CheckBox();

        /// <summary>
        /// ComboBox Helper Components
        /// </summary>
        public ComboBox ComboBox = new ComboBox();

        /// <summary>
        /// JavaScript Helper Components 
        /// </summary>
        public Javascript JavaScript = new Javascript();

        /// <summary>
        /// Label Helper Components
        /// </summary>
        public Label Label = new Label();

        /// <summary>
        /// Link Helper Components 
        /// </summary>
        public Link Link = new Link();

        /// <summary>
        /// Radio Button Helper Components
        /// </summary>
        public RadioButton RadioButton = new RadioButton();

        /// <summary>
        /// TextBox Helper Components
        /// </summary>
        public TextBox TextBox = new TextBox();

    }

}
