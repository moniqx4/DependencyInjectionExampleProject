using DataModelLibrary;
using OpenQA.Selenium;
using System;

namespace SeleniumWebDriver.WebElements
{
    public class JavaScriptHandler : IJavaScriptHandler
    {       
        private readonly IAlert _alert;
        private readonly IBrowser _browser;
       
        public JavaScriptHandler(IAlert alert, IBrowser browser)
        {
            _alert = alert;
            _browser = browser;
        }
        /// <summary>
        /// Clicks cancel button on the pop up in the browser
        /// </summary>
        public IJavaScriptExecutor ClickCancelOnPopup()
        {            
            if (!IsPopUpPresent())
                throw new Exception("Warning : No Pop Up Present");
            else
                _alert.DismissAlert();

            return (IJavaScriptExecutor)this;
        }

        /// <summary>
        /// Clicks Ok button on the pop up in the browser
        /// </summary>
        public IJavaScriptExecutor ClickOkOnPopup()
        {
            if (!IsPopUpPresent())
                throw new Exception("Warning : No Pop Up Present");
            else
                _alert.ClickAlertAcceptButton();

            return (IJavaScriptExecutor)this;
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
        /// Enters specified text in the pop up in the browser
        /// </summary>
        /// <param name="inputText">Text to be displayed in the pop up </param>
        public IJavaScriptExecutor TypeTextInPopUp(string inputText)
        {
            
            if (!IsPopUpPresent())
                throw new Exception( "Warning : No Pop Up Present");
            else
                _alert.TypeTextInAlert(inputText);

            return (IJavaScriptExecutor)this;
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

        public IJavaScriptExecutor ScrollToElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            throw new NotImplementedException();
        }
    }
}
