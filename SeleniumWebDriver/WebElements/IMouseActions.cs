using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IMouseActions
    {
        void DragNDrop(BaseLocatorModel locatorModelSrc, BaseLocatorModel locatorModelTrg, int waitTimeInSecs = 10);

        void ClickNHoldNDrop(BaseLocatorModel locatorModel, int x = 0, int y = 30, int waitTimeInSecs = 10);

        void DoubleClickOnElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);
    }
}
