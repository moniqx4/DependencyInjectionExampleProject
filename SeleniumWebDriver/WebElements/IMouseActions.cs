using DataModelLibrary;

namespace SeleniumWebDriver
{
    public interface IMouseActions
    {
        void DragNDrop(LocatorModel locatorModelSrc, LocatorModel locatorModelTrg);

        void ClickNHoldNDrop(LocatorModel locatorModel, int x = 0, int y = 30);

        void DoubleClickOnElement(LocatorModel locatorModel);
    }
}
