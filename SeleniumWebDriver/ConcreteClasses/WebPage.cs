using DataModelLibrary;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;
using System;

namespace SeleniumWebDriver.ConcreteClasses
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

        //public void IsComboBoxEnabled(LocatorModel locatorModel, string text, int index)
        //{
        //    _comboBox.IsComboBoxEnabled(locatorModel, index);
        //}
        public void JSTypeTextInPopUp(string inputtext)
        {
            _javascript.TypeTextInPopUp(inputtext);
        }

        public void JSScrollToElement(LocatorModel locatorModel)
        {
            _javascript.ScrollToElement(locatorModel);
        }

        public void JSClickOkOnPopup()
        {
            _javascript.ClickOkOnPopup();
        }

        public void JSClickOnCancel()
        {
            _javascript.ClickCancelOnPopup();
        }

        public string JSGetPopUpText()
        {
            return _javascript.GetPopUpText();
        }

        public bool JSIsPopUpPresent()
        {
            return _javascript.IsPopUpPresent();
        }
        
        public string JSGetPsuedoElementText(string locator, string keyword)
        {
            return _javascript.GetTextFromPsuedoElement(locator, keyword);
        }

        public string GetLabelText(LocatorModel locatorModel)
        {
            return _label.GetLabelText(locatorModel);
        }

        public void DoubleCommandKeyAction(string cmdKey1, string cmdKey2, string character)
        {
            _keyboardInteractions.DoubleCommandKeyAction(cmdKey1, cmdKey2, character);
        }

        public void SingleCommandKeyAction(string cmdKey, string character)
        {
            _keyboardInteractions.SingleCommandKeyAction(cmdKey, character);
        }

        public void DragNDrop(LocatorModel locatorModelSource, LocatorModel locatorModelTarget)
        {
            _mouseActions.DragNDrop(locatorModelSource, locatorModelTarget);
        }

        public void DoubleClickOnElement(LocatorModel locatorModel)
        {
            _mouseActions.DoubleClickOnElement(locatorModel);
        }

        public void ClickNHoldNDrop(LocatorModel locatorModel, int positionX, int positionY)
        {
            _mouseActions.ClickNHoldNDrop(locatorModel, positionX, positionY);
        }

        public void ComboxSelectByIndex(LocatorModel locatorModel,string text, int index)
        {
            _comboBox.SelectElementByVisibleText(locatorModel, text, index);
        }

        public void ComboxSelectByIndex(LocatorModel locatorModel, int index)
        {
            _comboBox.SelectElementByIndex(locatorModel, index);
        }

        public void ComboxSelectByValue(LocatorModel locatorModel, string value)
        {
            _comboBox.SelectElementByValue(locatorModel, value);
        }

        public string[][] GetTableData(ElementLocator row, ElementLocator col, LocatorModel locatorModel)
        {
            return _table.GetTable(row, col, locatorModel);
        }

        private bool IsSelectOptionAvailable(LocatorModel locatorModel)
        {
            return _select.IsSelectOptionAvailable(locatorModel.LocatorType, locatorModel.Locator);
        }

        public void SelectElementByIndex(int index, double timeout, LocatorModel locatorModel)
        {
            _select.SelectByIndex(index, timeout, locatorModel.LocatorType, locatorModel.Locator);
        }

        public void SelectElementByText(string value, double timeout, LocatorModel locatorModel)
        {
            _select.SelectByText(value, timeout, locatorModel.LocatorType, locatorModel.Locator);
        }

        public void SelectElementByValue(string value, double timeout, LocatorModel locatorModel)
        {
            _select.SelectByValue(value, timeout, locatorModel.LocatorType, locatorModel.Locator);
        }

        public void SelectElement(LocatorModel locatorModel)
        {
            _select.SelectElement(locatorModel.LocatorType,locatorModel.Locator);
        }

        public string GetLinkText(LocatorModel locatorModel)
        {
            return _link.GetLinkText(locatorModel);
        }

        public void AcceptAlert()
        {
            _alert.ClickAlertAcceptButton();
        }

        public void DismissAlert()
        {
            _alert.DismissAlert();
        }

        public string GetAlertText()
        {
            return _alert.GetAlertText();
        }

        public void SwitchToOpenAlert()
        {
            _alert.SwitchToAlert();
        }

      
      
        //public void ClickElement(LocatorModel locatorModel)
        //{
        //    switch (locatorModel.ElementType)
        //    {
        //        case ElementType.Button:
        //            _button.ClickButton(locatorModel);
        //            break;

        //        case ElementType.TextBox:
        //            _textBox.ClickIntoTextBox(locatorModel);
        //            break;

        //        case ElementType.Label:
        //            _label.ClickOnLabel(locatorModel);
        //            break;

        //        case ElementType.Link:
        //            _link.ClickLink(locatorModel);
        //            break;

        //        case ElementType.Radio:
        //            _radioButton.ClickOnRadioButton(locatorModel);
        //            break;

        //        case ElementType.Tab:
        //            _link.ClickLink(locatorModel);
        //            break;                

        //        default:
        //            throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

        //    }

        //}

        public IWebPage ClickElement(LocatorModel locatorModel)
        {
            switch (locatorModel.ElementType)
            {
                case ElementType.Button:
                    _button.ClickButton(locatorModel);
                    break;

                case ElementType.TextBox:
                    _textBox.ClickIntoTextBox(locatorModel);
                    break;

                case ElementType.Label:
                    _label.ClickOnLabel(locatorModel);
                    break;

                case ElementType.Link:
                    _link.ClickLink(locatorModel);
                    break;

                case ElementType.Radio:
                    _radioButton.ClickOnRadioButton(locatorModel);
                    break;

                case ElementType.Tab:
                    _link.ClickLink(locatorModel);
                    break;

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

            }

            return this;

        }

        public void CheckCheckbox(LocatorModel locatorModel, bool isEnabled)
        {
            _checkBox.ClickCheckBox(locatorModel, isEnabled);
        }    


        public IWebPage SetText(LocatorModel locatorModel, string text)
        {
            _textBox.ClearTextBox(locatorModel);
            _textBox.TypeInTextBox(locatorModel, text);

            return this;
        }

        //public void ExecuteJs()
        //{
            
        //}

        public string GetElementText(LocatorModel locatorModel)
        {
            switch (locatorModel.ElementType)
            {
                case ElementType.Button:
                    return _button.GetButtonText(locatorModel);

                case ElementType.TextBox:
                    return _textBox.GetTextBoxText(locatorModel);

                case ElementType.Label:
                    return _label.GetLabelText(locatorModel);

                case ElementType.Link:
                    return _link.GetLinkText(locatorModel);

                //case ElementType.Grid:
                //    return _table.GetTable(locatorModel);

                //case ElementType.Dropdown:
                //    return _comboBox.

                //case ElementType.Option:
                //    break;

                case ElementType.Alert:
                    return _alert.GetAlertText();

                //case ElementType.Modal:
                //    break;

                case ElementType.Header:
                    return _label.GetLabelText(locatorModel);

                case ElementType.Tab:
                    return _link.GetLinkText(locatorModel);

                //case ElementType.Checkbox:
                //    break;

                //case ElementType.Radio:
                //    return _radio. (locatorModel);

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");
            }
        }

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

                case ElementType.Link:
                    return _link.IsLinkEnabled(locatorModel);

                //case ElementType.Grid:
                //    break;
                //case ElementType.Dropdown:
                //    break;
                //case ElementType.Option:
                //    break;
                //case ElementType.Alert:
                //    break;
                //case ElementType.Modal:
                //    break;
                //case ElementType.Header:
                //    break;
                //case ElementType.Tab:
                //    break;
                //case ElementType.Checkbox:                    
                //    break;

                case ElementType.Radio:
                    return _radioButton.IsRadioButtonEnabled(locatorModel);

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

                case ElementType.Link:
                    return _link.IsLinkEnabled(locatorModel);

                //case ElementType.Grid:
                //    break;
                case ElementType.Dropdown:
                    return IsSelectOptionAvailable(locatorModel);

                //case ElementType.Option:

                //    break;

                //case ElementType.Alert:
                //    return _alert.

                //case ElementType.Modal:
                //    break;
                case ElementType.Header:
                    return _label.IsLabelEnabled(locatorModel);

                case ElementType.Tab:
                    return _link.IsLinkEnabled(locatorModel);

                default:
                    throw new Exception($"Unknown ElementType {locatorModel.ElementType}.");

            }
        }

    }
}
