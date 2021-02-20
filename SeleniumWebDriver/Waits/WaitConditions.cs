using OpenQA.Selenium;
using System;

namespace SeleniumWebDriver.Waits
{
    public sealed class WaitConditions
    {
        public static Func<IWebDriver, bool> ElementDisplayed(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                return element.Displayed;
            }

            return condition;
        }

        public static Func<IWebDriver, IWebElement> ElementIsDisplayed(IWebElement element)
        {
            IWebElement condition(IWebDriver driver)
            {
                try
                {
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
                catch (ElementNotVisibleException)
                {
                    return null;
                }
                catch (ElementNotInteractableException)
                {
                    return null;
                }
                catch (ElementNotSelectableException)
                {
                    return null;
                }
            }

            return condition;
        }

        public static Func<IWebDriver, bool> ElementNotDisplayed(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                try
                {
                    return !element.Displayed;
                }
                catch (StaleElementReferenceException)
                {

                    return true;
                }                
            }

            return condition;
        }

        // this one would check for a list of elements, need to modify for my element setup
        //public static Func<IWebDriver, bool> ElementsNotEmpty(Elements element)
        //{
        //    Elements condition(IWebDriver driver)
        //    {
        //        ElementsNotEmpty condition(IWebDriver driver)
        //        {
        //            Elements _elements = driver.FindElements(elements.FoundBy);
        //            return _elements.IsEmpty ? null : _elements;
        //        }
        //    }
        //    return condition;
        //}
    }
}
