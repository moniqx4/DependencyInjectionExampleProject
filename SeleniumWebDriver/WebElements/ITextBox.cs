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

        void ClearTextBox(BaseLocatorModel locatorModel, int timeInSec = 10);

        void ClearTextBox(BaseLocatorModel locatorModel, int index, int timeInSec = 10);

        bool IsTextBoxDisplayed(BaseLocatorModel locatorModel, int timeInSec = 10);

        bool IsTextBoxDisplayed(BaseLocatorModel locatorModel, int index, int timeInSec = 10);

        void TypeInTextBox(BaseLocatorModel locatorModel, string text, int timeInSec = 10);

        void TypeInTextBox(BaseLocatorModel locatorModel, string text, int index, int timeInSec = 10);

        string GetTextBoxText(BaseLocatorModel locatorModel, int timeInSec = 10);

        string GetTextBoxText(BaseLocatorModel locatorModel, int index, int timeInSec = 10);

        void ClickIntoTextBox(BaseLocatorModel locatorModel,int timeInSec = 10);

        void ClickIntoTextBox(BaseLocatorModel locatorModel, int index, int timeInSec = 10);
    }
}
