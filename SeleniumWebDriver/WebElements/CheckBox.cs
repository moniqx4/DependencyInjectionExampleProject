namespace SeleniumWebDriver.WebElements
{
    public class CheckBox : ICheckBox
    {
        /// <summary>
        /// Clicks on specified checkbox
        /// </summary>
        /// <param name="element">Checkbox Element</param>
        public void ClickCheckBox(Element element)
        {
            element.Click();
        }

        /// <summary>
        /// Determines if checkbox is Checked
        /// </summary>
        /// <param name="element">Checkbox Element</param>
        /// <returns>Returns True if checkbox is checked else False</returns>
        public bool IsCheckboxChecked(Element element)
        {
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Determines if checkbox enabled
        /// </summary>
        /// <param name="element">checkbox element</param>
        /// <returns>Returns true if checkbox is enabled else False</returns>
        public bool IsCheckboxEnbaled(Element element)
        {
            return element.Enabled;
        }
    }
}
