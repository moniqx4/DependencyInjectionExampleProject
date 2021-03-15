using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IJavaScript
    {
        bool IsPopUpPresent();

        string GetPopUpText();

        void ClickOkOnPopup();

        void ClickCancelOnPopup();

        void ScrollToElement(Element ele);

        void TypeTextInPopUp(string inputText);
    }
}
