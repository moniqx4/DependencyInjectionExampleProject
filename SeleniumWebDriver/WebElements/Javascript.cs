using DataModelLibrary;
using OpenQA.Selenium;
using System;

namespace SeleniumWebDriver.WebElements
{
    public class Javascript : IJavaScript
    {       
        private readonly IAlert _alert;
        private readonly IBrowser _browser;
        public Javascript(IAlert alert, IBrowser browser)
        {
            _alert = alert;
            _browser = browser;
        }
        /// <summary>
        /// Clicks cancel button on the pop up in the browser
        /// </summary>
        public void ClickCancelOnPopup()
        {            
            if (!IsPopUpPresent())
                throw new Exception("Warning : No Pop Up Present");
            else
                _alert.DismissAlert();
        }

        /// <summary>
        /// Clicks Ok button on the pop up in the browser
        /// </summary>
        public void ClickOkOnPopup()
        {
            if (!IsPopUpPresent())
                throw new Exception("Warning : No Pop Up Present");
            else
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
        public void ScrollToElement(LocatorModel locatorModel)
        {
            LocatorBuilder locatorBuilder = new LocatorBuilder();
            var ele = locatorBuilder.BuildLocator(locatorModel);

            ((IJavaScriptExecutor)_browser).ExecuteScript("arguments[0].scrollIntoView(true);", ele);
        }

        /// <summary>
        /// Enters specified text in the pop up in the browser
        /// </summary>
        /// <param name="inputText">Text to be displayed in the pop up </param>
        public void TypeTextInPopUp(string inputText)
        {
            
            if (!IsPopUpPresent())
                throw new Exception( "Warning : No Pop Up Present");
            else
                _alert.TypeTextInAlert(inputText);
        }

        /// <summary>
        /// This is a way to allow Selenium to handle Psuedo Elements via Javascript to get the content of the element
        /// </summary>
        /// <param name="locator">this would typlically be the class , for example .okButton</param>
        /// <param name="keyword"> examples would be :after, :before, :first-line, etc</param>
        /// <returns></returns>
        public string GetTextFromPsuedoElement(string locator, string keyword)
        {
            string script = $"return window.getComputedStyle(document.querySelector('{locator}'),'{keyword}').getPropertyValue('content')";
            IJavaScriptExecutor js = (IJavaScriptExecutor)_browser;
            return (string)js.ExecuteScript(script);
        }

    }
}
