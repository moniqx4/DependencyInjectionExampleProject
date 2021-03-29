using DataModelLibrary;
using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IJavaScript
    {
        bool IsPopUpPresent();

        string GetPopUpText();

        void ClickOkOnPopup();

        void ClickCancelOnPopup();       

        void TypeTextInPopUp(string inputText);

        void ScrollToElement(LocatorModel locatorModel);


    }
}
