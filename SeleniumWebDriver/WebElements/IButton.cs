using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IButton
    {       

        bool IsButtonEnabled(LocatorModel locatorModel, int index = 0);

        string GetButtonText(LocatorModel locatorModel, int index = 0);

        bool IsButtonPresent(LocatorModel locatorModel, int index = 0);

        void ClickButton(LocatorModel locatorModel);

    }
}
