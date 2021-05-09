using DataModelLibrary;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebDriver.WebElements
{
    public class MouseActions : SeleniumDriver, IMouseActions
    {
        private readonly ILocatorBuilder _locatorBuilder;

        public MouseActions(SeleniumConfiguration config, ILocatorBuilder locatorBuilder) : base(config)
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
        public void ClickNHoldNDrop(BaseLocatorModel locatorModel, int x = 0, int y = 30, int waitTimeInSecs = 10)
        {
            Actions act = new Actions(_browser);
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);

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
        public void DoubleClickOnElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            Actions act = new Actions(_browser);
            var element = _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs);

            act.DoubleClick(element)
                .Build()
                .Perform();
        }

        /// <summary>
        /// Drag an element and drop it in the spcified element
        /// </summary>
        /// <param name="locatorModelSrc">Source item IWebElement</param>
        /// <param name="locatorModelTrg">Target item IWebElement</param>
        public void DragNDrop(BaseLocatorModel locatorModelSrc, BaseLocatorModel locatorModelTrg, int waitTimeInSecs = 10)
        {
            var elementTrg = _locatorBuilder.BuildLocator(locatorModelTrg, waitTimeInSecs);
            var elementSrc = _locatorBuilder.BuildLocator(locatorModelSrc, waitTimeInSecs);

            Actions act = new Actions(_browser);

            act.DragAndDrop(elementSrc, elementTrg)
                .Build()
                .Perform();
        }

        /* ----- Multiple locators methods -----*/
    }
}
