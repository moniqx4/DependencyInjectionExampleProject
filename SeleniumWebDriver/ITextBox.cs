using DataModelLibrary;

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

        void ClearTextBox(LocatorModel locatorModel);

        void ClearTextBox(LocatorModel locatorModel, int index);

        void ClickIntoTextBox(LocatorType locatorType, string locator);

        void ClickIntoTextBox(LocatorType locatorType, string locator, int index);

        bool IsTextBoxDisplayed(LocatorModel locatorModel);

        bool IsTextBoxDisplayed(LocatorModel locatorModel, int index);

        void TypeInTextBox(LocatorModel locatorModel, string text);

        void TypeInTextBox(LocatorModel locatorModel, string text, int index);

        string GetTextBoxText(LocatorModel locatorModel);

        string GetTextBoxText(LocatorModel locatorModel, int index);

       

        void ClickIntoTextBox(LocatorModel locatorModel);

        void ClickIntoTextBox(LocatorModel locatorModel, int index);
    }
}
