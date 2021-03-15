using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {
        bool IsTextBoxEnabled(Element element);

        void TypeInTextBox(Element element, string text);

        string GetTextBoxText(Element element);

        void ClearTextBoxText(Element element);
    }
}
