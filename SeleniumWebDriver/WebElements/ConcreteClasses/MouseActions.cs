using DataModelLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
        /// <param LocatorModel.locatorType="locatorType">Type of Locator</param>
        /// <param LocatorModel.locator="locator">Type of Locator</param>
        /// <param name="trg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ClickNHoldNDrop(LocatorModel locatorModel, int x = 0, int y = 30)
        {
            Actions act = new Actions(SeleniumDriver.Browser);
            var element = _locatorBuilder.BuildLocator(locatorModel);

            act.ClickAndHold(element)
                .MoveToElement(element, x, y)
                .Release()
                .Build()
                .Perform();
        }

        /// <summary>
        /// Double clicks on the specified element 
        /// </summary>
        /// <param LocatorModel.locatorType="locatorType">Type of Locator</param>
        /// <param LocatorModel.locator="locator">Type of Locator</param>
        public void DoubleClickOnElement(LocatorModel locatorModel)
        {
            Actions act = new Actions(SeleniumDriver.Browser);
            var element = _locatorBuilder.BuildLocator(locatorModel);

            act.DoubleClick(element)
                .Build()
                .Perform();
        }

        /// <summary>
        /// Drag an element and drop it in the spcified element
        /// </summary>
        /// <param name="locatorModelSrc">Source item IWebElement</param>
        /// <param name="locatorModelTrg">Target item IWebElement</param>
        public void DragNDrop(LocatorModel locatorModelSrc, LocatorModel locatorModelTrg)
        {
            var elementTrg = _locatorBuilder.BuildLocator(locatorModelTrg);
            var elementSrc = _locatorBuilder.BuildLocator(locatorModelSrc);

            Actions act = new Actions(SeleniumDriver.Browser);

            act.DragAndDrop(elementSrc, elementTrg)
                .Build()
                .Perform();
        }

        /* ----- Multiple locators methods -----*/
    }
}
