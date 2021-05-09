using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.Shared
{
    public class Element : BasePageObject, IElement
    {

        private readonly IWebPage _webPage;

        public Element(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public IElement ClickAnyElement(BaseLocatorModel locator, int waitTimeInSec)
        {

            ClickElement(locator, waitTimeInSec);

            return this;           
        }

        public IElement SetTextboxText(BaseLocatorModel locator, string text, int waitTimeInSec = 10)
        {

            SetTextBox(locator, text, waitTimeInSec);

            return this;
        }

        public string GetText(BaseLocatorModel locator, int waitTimeInSec = 10)
        {

            return GetTextElement(locator, waitTimeInSec);
            
        }

        public IElement ClickCheckboxElement(BaseLocatorModel locator, bool isChecked, int waitTimeInSec = 10)
        {
            ClickCheckbox(locator, isChecked, waitTimeInSec);

            return this;
        }

        public bool ElementExists(BaseLocatorModel locator, int waitTimeInSec = 10)
        {
            return _webPage.IsDisplayed(locator, waitTimeInSec);
        }

        public bool IsChecked(BaseLocatorModel locator, int waitTimeInSec = 10)
        {
            throw new System.NotImplementedException();
        }
    }
}
