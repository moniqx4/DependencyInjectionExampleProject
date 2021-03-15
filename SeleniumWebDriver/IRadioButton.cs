using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IRadioButton
    {
        bool IsRadioButtonSelected(Element element);

        bool IsRadioButtonEnabled(Element element);

        void ClickOnRadioButton(Element element);
    }
}
