using OpenQA.Selenium.Interactions;

namespace SeleniumWebDriver.WebElements
{
    public class MouseActions : IMouseActions
    {
        /// <summary>
        /// Clicks on a element, hold and drop it on the specified location
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="trg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ClickNHoldNDrop(Element Element, Element trg, int x = 0, int y = 30)
        {
            Actions act = new Actions(SeleniumDriver.Browser);

            act.ClickAndHold(Element)
                .MoveToElement(trg, x, y)
                .Release()
                .Build()
                .Perform();
        }

        /// <summary>
        /// Double clicks on the specified element 
        /// </summary>
        /// <param name="element">Item to be double clicked, its WebElement </param>
        public void DoubleClickOnElement(Element element)
        {
            Actions act = new Actions(SeleniumDriver.Browser);

            act.DoubleClick(element)
                .Build()
                .Perform();
        }

        /// <summary>
        /// Drag an element and drop it in the spcified element
        /// </summary>
        /// <param name="src">Source item WebElement</param>
        /// <param name="trg">Target item WebElement</param>
        public void DragNDrop(Element src, Element trg)
        {
            Actions act = new Actions(SeleniumDriver.Browser);

            act.DragAndDrop(src, trg)
                .Build()
                .Perform();
        }
    }
}
