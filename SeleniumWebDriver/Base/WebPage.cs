using SeleniumWebDriver.Type;
using System;

namespace SeleniumWebDriver.Base
{
    public class WebPage : IWebPage
    {
        private readonly ITextBox _textBox;
        private readonly IButton _button;
        private readonly ILink _link;

        public WebPage(ITextBox textBox, IButton button, ILink link)
        {
            _textBox = textBox;
            _button = button;
            _link = link;
        }

        public void ClickElement(LocatorType type, string locator, ElementType elementType)
        {
            switch (elementType)
            {
                case ElementType.Button:
                    _button.ClickButton(type, locator);
                    break;

                case ElementType.TextBox:
                    _textBox.ClickIntoTextBox(type, locator);
                    break;

                case ElementType.Option:
                    _link.ClickLink(type, locator);
                    break;

                case ElementType.Link:
                    _link.ClickLink(type, locator);
                    break;

                default: 
                    throw new Exception($"Unknown ElementType {elementType}.");

            }
            
        }
      

        public string GetText(LocatorType type, string locator)
        {
            return _textBox.GetTextBoxText(type, locator);           
        }

        public void SetText(LocatorType type, string locator, string text)
        {
            _textBox.ClearTextBox(type, locator);
            _textBox.TypeInTextBox(type, locator, text);
        }
     
    }
}
