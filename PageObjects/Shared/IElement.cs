using DataModelLibrary;

namespace PageObjects.Shared
{
    
    public interface IElement
    {
        IElement ClickAnyElement(BaseLocatorModel locator, int waitTimeInSec = 10);

        IElement SetTextboxText(BaseLocatorModel locator, string text, int waitTimeInSec = 10);

        IElement ClickCheckboxElement(BaseLocatorModel locator, bool isChecked, int waitTimeInSec = 10);

        string GetText(BaseLocatorModel locator, int waitTimeInSec = 10);

        bool ElementExists(BaseLocatorModel locator, int waitTimeInSec = 10);

        bool IsChecked(BaseLocatorModel locator, int waitTimeInSec = 10);

    }
}
