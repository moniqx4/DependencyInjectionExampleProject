using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {
        bool IsTextBoxDisplayed(LocatorType locatorType, string locator);

        bool IsTextBoxDisplayed(LocatorType locatorType, string locator, int index);

        void TypeInTextBox(LocatorType locatorType, string locator, string text);

        void TypeInTextBox(LocatorType locatorType, string locator, string text, int index);

        string GetTextBoxText(LocatorType locatorType, string locator);

        string GetTextBoxText(LocatorType locatorType, string locator, int index);

        void ClearTextBox(LocatorType locatorType, string locator);

        void ClearTextBox(LocatorType locatorType, string locator, int index);

        void ClickIntoTextBox(LocatorType locatorType, string locator);

        void ClickIntoTextBox(LocatorType locatorType, string locator, int index);
    }
}
