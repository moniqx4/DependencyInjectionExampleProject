using DataModelLibrary;
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

        public void ClickRadioButton(LocatorType locatorType, string locator)
        {
            _radioButton.ClickOnRadioButton(locatorType, locator);
        }

        public void ClickRadioButton(LocatorModel locatorModel)
        {
            _radioButton.ClickOnRadioButton(locatorModel);
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

        public void ClickElement(LocatorModel locatorModel)
        {
            switch (locatorModel.ElementType)
            {
                case ElementType.Button:
                    _button.ClickButton(locatorModel);
                    break;

                case ElementType.TextBox:
                    _textBox.ClickIntoTextBox(locatorModel);
                    break;

                case ElementType.Option:
                    _link.ClickLink(locatorModel);
                    break;

                case ElementType.Link:
                    _link.ClickLink(locatorModel);
                    break;

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

            }

        }

        public void CheckCheckbox(LocatorType type, string locator, bool isEnabled)
        {
            _checkBox.ClickCheckBox(type, locator, isEnabled);
        }

        public void CheckCheckbox(LocatorModel locatorModel, bool isEnabled)
        {
            _checkBox.ClickCheckBox(locatorModel, isEnabled);
        }

        public string GetText(LocatorType type, string locator)
        {
            return _textBox.GetTextBoxText(type, locator);           
        }

        public string GetText(LocatorModel locatorModel)
        {
            return _textBox.GetTextBoxText(locatorModel);
        }

        public void SetText(LocatorType type, string locator, string text)
        {
            _textBox.ClearTextBox(type, locator);
            _textBox.TypeInTextBox(type, locator, text);
        }

        public void SetText(LocatorModel locatorModel, string text)
        {
            _textBox.ClearTextBox(locatorModel);
            _textBox.TypeInTextBox(locatorModel, text);
        }

        //public void ExecuteJs()
        //{
            
        //}

        public bool IsDisplayed(LocatorModel locatorModel)
        {
            switch (locatorModel.ElementType)
            {
                case ElementType.Button:
                    return _button.IsButtonPresent(locatorModel);                    

                case ElementType.TextBox:                   
                    return _textBox.IsTextBoxDisplayed(locatorModel);

                case ElementType.Label:
                    return _label.IsLabelPresent(locatorModel);

                //case ElementType.Checkbox:
                //    return _checkBox.IsCheckboxEnabled(locatorModel.LocatorType, locatorModel.Locator);

                //case ElementType.Radio:
                //    return _radioButton.IsRadioButtonEnabled(locatorModel.LocatorType, locatorModel.Locator);

                //case ElementType.Label:
                //    return _label.IsLabelEnabled(locatorModel.LocatorType, locatorModel.Locator);


                //case ElementType.Option:
                //    _link.ClickLink(locatorModel.LocatorType, locatorModel.Locator);
                //    _link.
                //    break;

                //case ElementType.Link:
                //    _link.ClickLink(locatorModel.LocatorType, locatorModel.Locator);
                //    break;

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

            }
        }

        public bool IsActive(LocatorModel locatorModel)
        {
            switch (locatorModel.ElementType)
            {
                case ElementType.Button:
                    return _button.IsButtonEnabled(locatorModel);

                case ElementType.TextBox:
                    return _textBox.IsTextBoxDisplayed(locatorModel);

                case ElementType.Checkbox:
                    return _checkBox.IsCheckboxEnabled(locatorModel);

                case ElementType.Radio:
                    return _radioButton.IsRadioButtonEnabled(locatorModel);

                case ElementType.Label:
                    return _label.IsLabelEnabled(locatorModel);


                //case ElementType.Option:
                //    _link.ClickLink(locatorModel);
                //    _link.
                //    break;

                //case ElementType.Link:
                //    _link.ClickLink(locatorModel);
                //    break;

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

            }
        }

    }
}
