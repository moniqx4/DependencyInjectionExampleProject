using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IButton
    {
        bool IsButtonEnabled(Element element);

        void ClickButton(Element element);

        string GetButtonText(Element element);
    }
}
