using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {
        bool IsTextBoxDisplayed(LocatorType locatorType, string locator);

        void TypeInTextBox(LocatorType locatorType, string locator, string text);

        string GetTextBoxText(LocatorType locatorType, string locator);

        void ClearTextBox(LocatorType locatorType, string locator);

        void ClickIntoTextBox(LocatorType locatorType, string locator);
    }
}
