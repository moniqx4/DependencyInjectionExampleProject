using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IComboBox
    {
        void SelectElementByIndex(Element element, int index);

        void SelectElementByValue(Element element, string value);

        void SelectElementByVIsibleText(Element element, string visibleText);

        bool IsComboBoxEnabled(Element element);
    }
}
