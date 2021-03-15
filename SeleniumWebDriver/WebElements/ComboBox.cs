using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver.WebElements
{
    public class ComboBox: IComboBox
    {
        private static SelectElement select;


        public bool IsComboBoxEnabled(Element element)
        {
            return element.Enabled;
        }


        public void SelectElementByIndex(Element element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }


        public void SelectElementByValue(Element element, string value)
        {
            select = new SelectElement(element);
            select.SelectByValue(value);
        }


        public void SelectElementByVIsibleText(Element element, string visibleText)
        {
            select = new SelectElement(element);
            select.SelectByText(visibleText);
        }
    }
}
