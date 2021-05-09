using DataModelLibrary;
using OpenQA.Selenium;
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
        private readonly IJavaScriptHandler _javascript;
        private readonly IRadioButton _radioButton;
        private readonly ICheckBox _checkBox;

        private readonly ILocatorBuilder _locatorBuilder;

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
            IJavaScriptHandler javascript,
            IRadioButton radioButton,
            ICheckBox checkBox,
            ILocatorBuilder locatorBuilder)
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
            _locatorBuilder = locatorBuilder;
           
        }

        //public void IsComboBoxEnabled(LocatorModel locatorModel, string text, int index)
        //{
        //    _comboBox.IsComboBoxEnabled(locatorModel, index);
        //}
        public IJavaScriptExecutor JSTypeTextInPopUp(string inputtext)
        {
            _javascript.TypeTextInPopUp(inputtext);

            return (IJavaScriptExecutor)this;
        }

        public IJavaScriptExecutor JSScrollToElement(BaseLocatorModel locatorModel, int waitTimeInSecs)
        {
            return _javascript.ScrollToElement(locatorModel, waitTimeInSecs);
        }

        public IJavaScriptExecutor JSClickOkOnPopup()
        {
            return _javascript.ClickOkOnPopup();
        }

        public IJavaScriptExecutor JSClickOnCancel()
        {
            return _javascript.ClickCancelOnPopup();
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

        public string GetLabelText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            return _label.GetLabelText(locatorModel, waitTimeInSecs);
        }

        public void DoubleCommandKeyAction(string cmdKey1, string cmdKey2, string character)
        {
            _keyboardInteractions.DoubleCommandKeyAction(cmdKey1, cmdKey2, character);
        }

        public void SingleCommandKeyAction(string cmdKey, string character)
        {
            _keyboardInteractions.SingleCommandKeyAction(cmdKey, character);
        }

        public void DragNDrop(BaseLocatorModel locatorModelSource, BaseLocatorModel locatorModelTarget, int waitTimeInSecs = 10)
        {
            _mouseActions.DragNDrop(locatorModelSource, locatorModelTarget, waitTimeInSecs);
        }

        public void DoubleClickOnElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10)
        {
            _mouseActions.DoubleClickOnElement(locatorModel, waitTimeInSecs);
        }

        public void ClickNHoldNDrop(BaseLocatorModel locatorModel, int positionX, int positionY, int waitTimeInSecs = 10)
        {
            _mouseActions.ClickNHoldNDrop(locatorModel, positionX, positionY, waitTimeInSecs);
        }

        public void ComboxSelectByIndex(BaseLocatorModel locatorModel,string text, int index, int waitTimeInSecs = 10)
        {
            _comboBox.SelectElementByVisibleText(locatorModel, text, index, waitTimeInSecs);
        }

        public void ComboxSelectByIndex(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10)
        {
            _comboBox.SelectElementByIndex(locatorModel, index, waitTimeInSecs);
        }

        public void ComboxSelectByValue(BaseLocatorModel locatorModel, string value, int waitTimeInSecs = 10)
        {
            _comboBox.SelectElementByValue(locatorModel, value, waitTimeInSecs);
        }

        public string[][] GetTableData(ElementLocator row, ElementLocator col, BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            return _table.GetTable(row, col, locator, waitTimeInSecs);
        }

        private bool IsSelectOptionAvailable(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            return _select.IsSelectOptionAvailable(locator, waitTimeInSecs);
        }

        public void SelectElementByIndex(int index, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            _select.SelectByIndex(index, timeout, locator, waitTimeInSecs);
        }

        public void SelectElementByText(string value, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            _select.SelectByText(value, timeout, locator, waitTimeInSecs);
        }

        public void SelectElementByValue(string value, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            _select.SelectByValue(value, timeout, locator, waitTimeInSecs);
        }

        public void SelectElement(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            _select.SelectElement(locator, waitTimeInSecs);
        }

        public string GetLinkText(BaseLocatorModel locator, int waitTimeInSecs = 10)
        {
            return _link.GetLinkText(locator);
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

        //public void ExecuteJs()
        //{
            
        //}

       
        public bool IsDisplayed(BaseLocatorModel locatorModel, int waitTimeInSecs)
        {
            return _locatorBuilder.BuildLocator(locatorModel, waitTimeInSecs).Displayed;            
        }
       
      
        public IWebPage ClickElement(BaseLocatorModel locator, int waitTimeInSecs)
        {

            var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            element.Click();

            return this;
        }

        public IWebPage CheckCheckbox(BaseLocatorModel locator, bool isEnabled, int waitTimeInSecs)
        {
            var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            _checkBox.ClickCheckBox(locator, waitTimeInSecs);

            return this;
        }

        public string GetElementText(BaseLocatorModel locator, int waitTimeInSecs)
        {
            var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            return element.Text;
        }

        public IWebPage SetText(BaseLocatorModel locator, string text, int waitTimeInSecs)
        {
            _textBox.TypeInTextBox(locator, text);

            return this;
        }

        public bool IsCheckBoxChecked(BaseLocatorModel locator, int waitTimeInSecs)
        {            
            return _checkBox.IsCheckboxChecked(locator, waitTimeInSecs);            
        }

        public IJavaScriptExecutor JSExecuteClickElement(string script)
        {
            //var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            throw new NotImplementedException();
        }

        public string JSExecuteGetElementText(string script)
        {
            //var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            throw new NotImplementedException();
        }

        public IJavaScriptExecutor JSExecuteSetElementText(string script, string text)
        {
            //var element = _locatorBuilder.BuildLocator(locator, waitTimeInSecs);
            throw new NotImplementedException();
        }
      
    }
}
