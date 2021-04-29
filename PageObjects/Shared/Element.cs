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

        public IElement ClickEle(BaseLocatorModel locator)
        {

            ClickElement(locator);

            return this;           
        }

        public IElement SetTextboxText(BaseLocatorModel locator, string text)
        {

            SetTextBox(locator, text);

            return this;
        }

        public string GetText(BaseLocatorModel locator)
        {

            return GetTextElement(locator);
            
        }

        public IElement ClickCheckboxElement(BaseLocatorModel locator, bool isChecked)
        {
            ClickCheckbox(locator, isChecked);

            return this;
        }


    }
}
