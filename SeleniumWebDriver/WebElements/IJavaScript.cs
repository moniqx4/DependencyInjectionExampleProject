using DataModelLibrary;
using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IJavaScript
    {
        bool IsPopUpPresent();

        string GetPopUpText();

        IJavaScriptExecutor ClickOkOnPopup();

        IJavaScriptExecutor ClickCancelOnPopup();

        IJavaScriptExecutor TypeTextInPopUp(string inputText);

        IJavaScriptExecutor ScrollToElement(LocatorModel locatorModel);

        string GetTextFromPsuedoElement(string locator, string keyword);


    }
}
