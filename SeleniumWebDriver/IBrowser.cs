using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IBrowser
    {
        IWebDriver BrowserAction();
        string GetBrowserTitle();

        string GetBrowserUrl();

        string GetAlertText();

        IBrowser SwitchToAlert();        

        IBrowser SetTextInAlert(string text);

        INavigation NavigateTo(string url);

        INavigation MoveForward();

        INavigation MoveBackward();

        void BrowserMaximize();

        void BrowserMinimize();

        INavigation BrowserRefresh();

        ITargetLocator SwitchToWindow(int index = 0);

        ITargetLocator SwitchToParent();

        ITargetLocator SwitchToFrame(IWebElement frameElement);

        void ClickAlertAcceptButton();

        void DismissAlert();

        void Close();
    }
}
