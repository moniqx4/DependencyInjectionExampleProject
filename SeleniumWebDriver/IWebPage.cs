using DataModelLibrary;
using OpenQA.Selenium;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {

        IWebElement HandleElement(BaseLocatorModel locator, int waitTimeInSecs);

        public IWebPage ClickElement(BaseLocatorModel locator, int waitTimeInSecs = 10);
     

        IWebPage CheckCheckbox(BaseLocatorModel locator, bool isEnabled, int waitTimeInSecs = 10);
      

        string GetElementText(BaseLocatorModel locator, int waitTimeInSecs = 10);
     

        IWebPage SetText(BaseLocatorModel locator, string text, int waitTimeInSecs = 10);

        bool IsCheckBoxChecked(BaseLocatorModel locator, int waitTimeInSecs = 10);
  

        bool IsDisplayed(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);
      

        void AcceptAlert();

        void SwitchToOpenAlert();

        string GetAlertText();

        void DismissAlert();


        void SingleCommandKeyAction(string cmdKey, string character);

        void DoubleCommandKeyAction(string cmdKey1, string cmdKey2, string character);
     

        IJavaScriptExecutor JSExecuteClickElement(string script);

        string JSExecuteGetElementText(string script);

        IJavaScriptExecutor JSExecuteSetElementText(string script, string text);

        IJavaScriptExecutor JSTypeTextInPopUp(string inputtext);
    

        IJavaScriptExecutor JSClickOkOnPopup();

        IJavaScriptExecutor JSClickOnCancel();

        string JSGetPopUpText();

        bool JSIsPopUpPresent();

        IJavaScriptExecutor JSScrollToElement(BaseLocatorModel locatorModel, int waitTimeInSecs);

        string JSGetPsuedoElementText(string locator, string keyword);

        string GetLinkText(BaseLocatorModel locator, int waitTimeInSecs = 10);

        string GetLabelText(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void DragNDrop(BaseLocatorModel locatorModelSource, BaseLocatorModel locatorModelTarget, int waitTimeInSecs = 10);

        void DoubleClickOnElement(BaseLocatorModel locatorModel, int waitTimeInSecs = 10);

        void ClickNHoldNDrop(BaseLocatorModel locatorModel, int positionX, int positionY, int waitTimeInSecs = 10);

        void ComboxSelectByIndex(BaseLocatorModel locatorModel, string text, int index, int waitTimeInSecs = 10);

        void ComboxSelectByIndex(BaseLocatorModel locatorModel, int index, int waitTimeInSecs = 10);

        void ComboxSelectByValue(BaseLocatorModel locatorModel, string value, int waitTimeInSecs = 10);

        string[][] GetTableData(ElementLocator row, ElementLocator col, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectElementByIndex(int index, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectElementByText(string value, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectElementByValue(string value, double timeout, BaseLocatorModel locator, int waitTimeInSecs = 10);

        void SelectElement(BaseLocatorModel locator, int waitTimeInSecs = 10);


    }
}
