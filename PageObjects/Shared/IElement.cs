using DataModelLibrary;

namespace PageObjects.Shared
{
    
    public interface IElement
    {
        IElement ClickEle(BaseLocatorModel locator);

        IElement SetTextboxText(BaseLocatorModel locator, string text);

        IElement ClickCheckboxElement(BaseLocatorModel locator, bool isChecked);

        string GetText(BaseLocatorModel locator);

    }
}
