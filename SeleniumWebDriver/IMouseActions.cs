using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IMouseActions
    {
        void DragNDrop(Element src, Element trg);

        void ClickNHoldNDrop(Element element, Element trg, int x = 0, int y = 30);

        void DoubleClickOnElement(Element element);
    }
}
