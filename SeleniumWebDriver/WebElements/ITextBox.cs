using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {

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
