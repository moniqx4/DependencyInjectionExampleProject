using OpenQA.Selenium;

namespace SeleniumWebDriver.WebElements
{
    public class Javascript : IJavaScript
    {
        /// <summary>
        /// Clicks cancel button on the pop up in the browser
        /// </summary>
        public void ClickCancelOnPopup()
        {
            SeleniumDriver.Browser.SwitchTo().Alert().Dismiss();
        }

        /// <summary>
        /// Clicks Ok button on the pop up in the browser
        /// </summary>
        public void ClickOkOnPopup()
        {
            SeleniumDriver.Browser.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Retrieves text displayed in the pop up in the browser
        /// </summary>
        /// <returns>Text in the pop up </returns>
        public string GetPopUpText()
        {
            if (!IsPopUpPresent())
                return "Warning : No Pop Up Present";
            else
                return SeleniumDriver.Browser.SwitchTo().Alert().Text;
        }

        /// <summary>
        /// Determines if the pop up is present in the browser 
        /// </summary>
        /// <returns></returns>
        public bool IsPopUpPresent()
        {
            try
            {
                SeleniumDriver.Browser.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        /// <summary>
        /// Scroll to specified WebElement
        /// </summary>
        /// <param name="ele">WebElement to focus</param>
        public void ScrollToElement(Element ele)
        {
            ((IJavaScriptExecutor)SeleniumDriver.Browser).ExecuteScript("arguments[0].scrollIntoView(true);", ele);
        }

        /// <summary>
        /// Enters specified text in the pop up in the browser
        /// </summary>
        /// <param name="inputText">Text to be displayed in the pop up </param>
        public void TypeTextInPopUp(string inputText)
        {
            SeleniumDriver.Browser.SwitchTo().Alert().SendKeys(inputText);
        }
    }
}
