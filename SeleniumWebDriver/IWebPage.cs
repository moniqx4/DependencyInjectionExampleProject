using DataModelLibrary;
using SeleniumWebDriver.Type;

namespace SeleniumWebDriver
{
    public interface IWebPage
    {

        IWebPage ClickElement(LocatorModel locatorModel);

        void CheckCheckbox(LocatorModel locatorModel, bool isEnabled);

        string GetElementText(LocatorModel locatorModel);

        IWebPage SetText(LocatorModel locatorModel, string text);       

        bool IsDisplayed(LocatorModel locatorModel);

        bool IsActive(LocatorModel locatorModel);

        void AcceptAlert();

        void SwitchToOpenAlert();

        string GetAlertText();

        void DismissAlert();

        string GetLinkText(LocatorModel locatorModel);

        void SelectElement(LocatorModel locatorModel);

        void SelectElementByValue(string value, double timeout, LocatorModel locatorModel);

        void SelectElementByText(string value, double timeout, LocatorModel locatorModel);

        void SelectElementByIndex(int index, double timeout, LocatorModel locatorModel);

        string[][] GetTableData(ElementLocator row, ElementLocator col, LocatorModel locatorModel);

        void ComboxSelectByIndex(LocatorModel locatorModel, int index);

        void ComboxSelectByValue(LocatorModel locatorModel, string value);

        void ComboxSelectByIndex(LocatorModel locatorModel, string text, int index);

        void ClickNHoldNDrop(LocatorModel locatorModel, int positionX, int positionY);

        void DoubleClickOnElement(LocatorModel locatorModel);

        void DragNDrop(LocatorModel locatorModelSource, LocatorModel locatorModelTarget);

        void SingleCommandKeyAction(string cmdKey, string character);

        void DoubleCommandKeyAction(string cmdKey1, string cmdKey2, string character);

        string GetLabelText(LocatorModel locatorModel);

        void JSTypeTextInPopUp(string inputtext);

        void JSScrollToElement(LocatorModel locatorModel);

        void JSClickOkOnPopup();

        void JSClickOnCancel();

        string JSGetPopUpText();

        bool JSIsPopUpPresent();

        string JSGetPsuedoElementText(string locator, string keyword);


    }
}
