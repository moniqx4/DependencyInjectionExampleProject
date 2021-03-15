using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface ILink
    {
        bool IsLinkEnabled(Element element);

        string GetLinkText(Element element);

        void ClickOnLink(Element element);
    }
}
