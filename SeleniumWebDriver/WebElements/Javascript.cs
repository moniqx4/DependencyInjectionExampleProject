using OpenQA.Selenium;

namespace SeleniumWebDriver.WebElements
{
    public class Javascript : IJavaScript
    {       
        private readonly IAlert _alert;
        public Javascript(IAlert alert)
        {            
            _alert = alert;
        }
        /// <summary>
        /// Clicks cancel button on the pop up in the browser
        /// </summary>
        public void ClickCancelOnPopup()
        {
            _alert.DismissAlert();
        }

        /// <summary>
        /// Clicks Ok button on the pop up in the browser
        /// </summary>
        public void ClickOkOnPopup()
        {            
            _alert.ClickAlertAcceptButton();
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
                return _alert.GetAlertText();
        }

        /// <summary>
        /// Determines if the pop up is present in the browser 
        /// </summary>
        /// <returns></returns>
        public bool IsPopUpPresent()
        {
            try
            {
                _alert.SwitchToAlert();
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
        public void ScrollToElement(IWebElement ele)
        {
            ((IJavaScriptExecutor)SeleniumDriver.Browser).ExecuteScript("arguments[0].scrollIntoView(true);", ele);
        }

        /// <summary>
        /// Enters specified text in the pop up in the browser
        /// </summary>
        /// <param name="inputText">Text to be displayed in the pop up </param>
        public void TypeTextInPopUp(string inputText)
        {
            _alert.TypeTextInAlert(inputText);
        }
    }
}
