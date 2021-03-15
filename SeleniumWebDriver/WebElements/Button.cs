namespace SeleniumWebDriver.WebElements
{
    public class Button : IButton
    {
        /// <summary>
        /// Clicks on specified button
        /// </summary>
        /// <param name="element">Button WebElement</param>
        public void ClickButton(Element element)
        {
            element.Click();
        }

        /// <summary>
        /// Retrieve text displayed on specified button
        /// </summary>
        /// <param name="element">Button WebElement</param>
        /// <returns>Button Text</returns>
        public string GetButtonText(Element element)
        {
            return element.Text;
        }

        /// <summary>
        /// Determines if the element is enabled or not 
        /// </summary>
        /// <param name="element">Button WebElement </param>
        /// <returns>Return True if button is enabled else False</returns>
        public bool IsButtonEnabled(Element element)
        {
            return element.Enabled;
        }
    }
}
