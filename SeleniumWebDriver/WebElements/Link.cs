namespace SeleniumWebDriver.WebElements
{
    public class Link : ILink
    {
        /// <summary>
        /// Clicks on Link
        /// </summary>
        /// <param name="element">Link WebElement</param>
        public void ClickOnLink(Element element)
        {
            element.Click();
        }

        /// <summary>
        /// Retrieves Link's text
        /// </summary>
        /// <param name="element">Link WebElement</param>
        /// <returns></returns>
        public string GetLinkText(Element element)
        {
            return element.Text;
        }

        /// <summary>
        /// Determines if link is enabled 
        /// </summary>
        /// <param name="element">Link's WebElement</param>
        /// <returns></returns>
        public bool IsLinkEnabled(Element element)
        {
            return element.Enabled;
        }
    }
}
