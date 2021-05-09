using DataModelLibrary;
using OpenQA.Selenium;

namespace SeleniumWebDriver.WebElements
{
    public interface IJavaScriptHandler
    {
        bool IsPopUpPresent();

        string GetPopUpText();

        IJavaScriptExecutor ClickOkOnPopup();

        IJavaScriptExecutor ClickCancelOnPopup();

        IJavaScriptExecutor TypeTextInPopUp(string inputText);

        IJavaScriptExecutor ScrollToElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        string GetTextFromPsuedoElement(string locator, string keyword);

    }
}
