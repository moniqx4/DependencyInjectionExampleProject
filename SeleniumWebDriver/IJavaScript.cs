using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IJavaScript
    {
        bool IsPopUpPresent();

        string GetPopUpText();

        void ClickOkOnPopup();

        void ClickCancelOnPopup();

        void ScrollToElement(IWebElement ele);

        void TypeTextInPopUp(string inputText);
    }
}
