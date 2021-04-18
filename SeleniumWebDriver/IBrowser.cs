using OpenQA.Selenium;

namespace SeleniumWebDriver
{
    public interface IBrowser
    {
        string GetBrowserTitle();

        string GetBrowserUrl();

        string GetAlertText();

        IBrowser SwitchToAlert();        

        IBrowser SetTextInAlert(string text);

        void NavigateTo(string url);

        void MoveForward();

        void MoveBackward();

        void BrowserMaximize();

        void BrowserMinimize();

        void BrowserRefresh();

        void SwitchToWindow(int index = 0);

        void SwitchToParent();

        void SwitchToFrame(IWebElement frameElement);

        void ClickAlertAcceptButton();

        void DismissAlert();

        void Close();
    }
}
