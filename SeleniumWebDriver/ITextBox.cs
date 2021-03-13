using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface ITextBox
    {
        bool IsTextBoxEnabled(IWebElement element);

        void TypeInTextBox(IWebElement element, string text);

        string GetTextBoxText(IWebElement element);

        void ClearTextBoxText(IWebElement element);
    }
}
