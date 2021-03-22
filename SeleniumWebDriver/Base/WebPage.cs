using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;
using System;

namespace SeleniumWebDriver.Base
{
    public class WebPage : IWebPage
    {
        private readonly ITextBox _textBox;
        private readonly IButton _button;
        private readonly ILink _link;
        private readonly ISelect _select;
        private readonly ITable _table;
        private readonly IComboBox _comboBox;
        private readonly IMouseActions _mouseActions;
        private readonly IKeyboardInteractions _keyboardInteractions;
        private readonly ILabel _label;
        private readonly IAlert _alert;
        private readonly IJavaScript _javascript;
        private readonly IRadioButton _radioButton;
        private readonly ICheckBox _checkBox;

        public WebPage(ITextBox textBox,
            IButton button,
            ILink link,
            ISelect select,
            ITable table,
            IComboBox comboBox,
            IMouseActions mouseActions,
            IKeyboardInteractions keyboardInteractions,
            ILabel label,
            IAlert alert,
            IJavaScript javascript,
            IRadioButton radioButton,
            ICheckBox checkBox)
        {
            _textBox = textBox;
            _button = button;
            _link = link;
            _select = select;
            _table = table;
            _comboBox = comboBox;
            _mouseActions = mouseActions;
            _keyboardInteractions = keyboardInteractions;
            _label = label;
            _alert = alert;
            _javascript = javascript;
            _radioButton = radioButton;
            _checkBox = checkBox;
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

        public void CheckCheckbox(LocatorType type, string locator)
        {
            _checkBox.ClickCheckBox(type, locator);
        }

        public void UnCheckCheckbox(LocatorType type, string locator)
        {
            var isChecked = _checkBox.IsCheckboxEnabled(type, locator);
            if (isChecked)
            {
                _checkBox.ClickCheckBox(type, locator);
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
