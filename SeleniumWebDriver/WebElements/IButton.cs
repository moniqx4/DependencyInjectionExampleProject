using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IButton
    {       

        bool IsButtonEnabled(LocatorModel locatorModel, int index = 0);

        string GetButtonText(LocatorModel locatorModel, int index = 0);

        bool IsButtonPresent(LocatorModel locatorModel, int index = 0);

        void ClickButton(LocatorModel locatorModel);

        bool IsButtonEnabled(BaseLocatorModel locator, int index = 0);

        string GetButtonText(BaseLocatorModel locator, int index = 0);

        bool IsButtonPresent(BaseLocatorModel locator, int index = 0);

        void ClickButton(BaseLocatorModel locator);

    }
}
