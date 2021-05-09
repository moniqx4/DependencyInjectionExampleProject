using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IButton
    {  

        bool IsButtonEnabled(BaseLocatorModel locator, int index = 0, int waitTimeInSecs = 0);

        string GetButtonText(BaseLocatorModel locator, int index = 0, int waitTimeInSecs = 0);

        bool IsButtonPresent(BaseLocatorModel locator, int index = 0, int waitTimeInSecs = 0);

        void ClickButton(BaseLocatorModel locator, int waitTimeInSecs = 0);

    }
}
