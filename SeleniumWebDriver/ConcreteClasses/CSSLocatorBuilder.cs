using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using DataModelLibrary.Enums;

namespace SeleniumWebDriver.ConcreteClasses
{
    public partial class LocatorBuilder
    {
       

        public static IWebElement GetCSSLocatorElements(CSSLocators cssLocator, string value, int waitTimeInSecs)
        {           
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTimeInSecs));
            var cssloc = GetCSSLocatorString(cssLocator, value);

            return wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssloc)));

            //return cssLocator switch
            //{
            //    CSSLocators.ByTitle => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssloc))),
            //    CSSLocators.ByLanguage => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[p:lang='({value})']"))),
            //    CSSLocators.ByEnabled => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[:enabled]"))),
            //    CSSLocators.ByChecked => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[:checked]"))),
            //    CSSLocators.ByDisabled => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[:disabled]"))),

            //    CSSLocators.ByEmpty => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[:empty]"))),
            //    CSSLocators.ByPFirstChild => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[p:first-child]"))),
            //    CSSLocators.ByFocus => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[:focused]"))),
            //    CSSLocators.ByPLastChild => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[p:last-child]"))),
            //    CSSLocators.ByListFirstChild => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[li:first-child]"))),
            //    CSSLocators.ByListLastChild => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[li:last-child]"))),
            //    CSSLocators.ByType => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector($"[{value}:only-of-type]"))),
            //    CSSLocators.ByParagraphFirstLine => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[p::first-line]"))),
            //    //CSSLocators. => _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(":disabled"))),
               
            //    _ => throw new Exception($"CSSLocatorType {cssLocator} with value: {value} is unknown."),
            //};

        }

        public static string GetCSSLocatorString(CSSLocators cssLocator, string value)
        {
            string cssloc;


            return cssLocator switch
            {
                CSSLocators.ByTitle => cssloc = $"[title~='{value}']",
                CSSLocators.ByLanguage => cssloc = $"[p:lang='({value})']",
                CSSLocators.ByEnabled => cssloc = "[:enabled]",
                CSSLocators.ByChecked => cssloc = "[:checked]",
                CSSLocators.ByDisabled => cssloc = "[:disabled]",
                CSSLocators.ByEmpty => cssloc = "[:empty]",
                CSSLocators.ByPFirstChild => cssloc = "[p:first-child]",
                CSSLocators.ByFocus => cssloc = "[:focused]",
                CSSLocators.ByPLastChild => cssloc = "[p:last-child]",
                CSSLocators.ByListFirstChild => cssloc = "[li:first-child]",
                CSSLocators.ByListLastChild => cssloc = "[li:last-child]",
                CSSLocators.ByType => cssloc = $"[{value}:only-of-type]",
                CSSLocators.ByParagraphFirstLine => cssloc = "[p::first-line]",
                //CSSLocators. => cssloc = "[:disabled]",

                _ => throw new Exception($"CSSLocatorType {cssLocator} with value: {value} is unknown.")
            };            

        }


    }
}
