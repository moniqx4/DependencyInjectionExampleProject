using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {       

        void ClearTextBox(LocatorModel locatorModel);

        void ClearTextBox(LocatorModel locatorModel, int index);       

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
