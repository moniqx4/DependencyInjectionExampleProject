using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface ILabel
    {
        bool IsLabelEnabled(Element element);

        string GetLabelText(Element element);

        void ClickOnLabel(Element element);
    }
}
