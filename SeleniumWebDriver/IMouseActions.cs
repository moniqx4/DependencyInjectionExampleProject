using OpenQA.Selenium;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IMouseActions
    {
        void DragNDrop(IWebElement src, IWebElement trg);

        void ClickNHoldNDrop(LocatorType locatorType, string locator, IWebElement trg, int x = 0, int y = 30);

        void DoubleClickOnElement(LocatorType locatorType, string locator);
    }
}
