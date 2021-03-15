namespace SeleniumWebDriver.WebElements
{
    public interface ICheckBox
    {
        void ClickCheckBox(Element element);

        bool IsCheckboxChecked(Element element);

        bool IsCheckboxEnbaled(Element element);
    }
}