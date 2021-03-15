using OpenQA.Selenium;

namespace SeleniumWebDriver.WebElements
{
    public class RadioButton : IRadioButton
    {
        /// <summary>
        /// Clicks on specified radio button 
        /// </summary>
        /// <param name="element">Radio button WebElement</param>
        public void ClickOnRadioButton(Element element)
        {
            element.Click();
        }

        /// <summary>
        /// Determines if the radio button is enabled
        /// </summary>
        /// <param name="element">Radio button WebElement</param>
        /// <returns>Returns True if Radio button is enabled else False</returns>
        public bool IsRadioButtonEnabled(Element element)
        {
            return element.Enabled;
        }

        /// <summary>
        /// Determines if the Radio button is already selected
        /// </summary>
        /// <param name="element">Radio button WebElement</param>
        /// <returns>Return True </returns>
        public bool IsRadioButtonSelected(Element element)
        {
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return true;
        }
    }
}
