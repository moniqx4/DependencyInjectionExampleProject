using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriver.Extensions
{
    public static class WebElementExtensions
    {
        /// <summary>
        /// Verify if actual element text equals to expected.
        /// </summary>
        /// <param name="webElement">The web element.</param>
        /// <param name="text">The text.</param>
        /// <returns>
        /// The <see cref="bool" />.
        /// </returns>
        public static bool IsElementTextEqualsToExpected(this IWebElement webElement, string text)
        {
            return webElement.Text.Equals(text);
        }

        /// <summary>
        /// Click on element using java script.
        /// </summary>
        /// <param name="webElement">The web element.</param>
        public static void JavaScriptClick(this IWebElement webElement)
        {
            if (!(webElement is IJavaScriptExecutor javascript))
            {
                throw new ArgumentException("Element must wrap a web driver that supports javascript execution");
            }

            javascript.ExecuteScript("arguments[0].click();", webElement);
        }

        /// <summary>
        /// Returns the textual content of the specified node, and all its descendants regardless element is visible or not.
        /// </summary>
        /// <param name="webElement">The web element.</param>
        /// <returns>The attribute.</returns>
        /// <exception cref="ArgumentException">Element must wrap a web driver
        /// or
        /// Element must wrap a web driver that supports javascript execution.</exception>
        public static string GetTextContent(this IWebElement webElement)
        {
            if (!(webElement is IJavaScriptExecutor javascript))
            {
                throw new ArgumentException("Element must wrap a web driver that supports javascript execution");
            }

            var textContent = (string)javascript.ExecuteScript("return arguments[0].textContent", webElement);
            return textContent;
        }
    }
}
