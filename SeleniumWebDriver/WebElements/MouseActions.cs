using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.WebElements
{
    public class MouseActions : IMouseActions
    {
        private readonly LocatorBuilder _locatorBuilder;

        public MouseActions(LocatorBuilder locatorBuilder)
        {
            _locatorBuilder = locatorBuilder;
        }
        /// <summary>
        /// Clicks on a element, hold and drop it on the specified location
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        /// <param name="trg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ClickNHoldNDrop(LocatorType locatorType, string locator, IWebElement trg, int x = 0, int y = 30)
        {
            Actions act = new Actions(SeleniumDriver.Browser);
            var element = _locatorBuilder.BuildLocator(locatorType, locator);

            act.ClickAndHold(element)
                .MoveToElement(trg, x, y)
                .Release()
                .Build()
                .Perform();
        }

        /// <summary>
        /// Double clicks on the specified element 
        /// </summary>
        /// <param locatorType="locatorType">Type of Locator</param>
        /// <param locator="locator">Type of Locator</param>
        public void DoubleClickOnElement(LocatorType locatorType, string locator)
        {
            Actions act = new Actions(SeleniumDriver.Browser);
            var element = _locatorBuilder.BuildLocator(locatorType, locator);

            act.DoubleClick(element)
                .Build()
                .Perform();
        }

        /// <summary>
        /// Drag an element and drop it in the spcified element
        /// </summary>
        /// <param name="src">Source item IWebElement</param>
        /// <param name="trg">Target item IWebElement</param>
        public void DragNDrop(IWebElement src, IWebElement trg)
        {
            Actions act = new Actions(SeleniumDriver.Browser);

            act.DragAndDrop(src, trg)
                .Build()
                .Perform();
        }
    }
}
