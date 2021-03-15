using SeleniumWebDriver.WebElements;

namespace SeleniumWebDriver
{
    public interface IBrowser
    {
        void NavigateTo(string url);
        void MoveForward();

        void MoveBackward();

        void BrowserMaximize();

        void BrowserMinimize();

        void BrowserRefresh();

        string GetBrowserTitle();

        string GetBrowserUrl();

        void SwitchToWindow(int index = 0);

        void SwitchToParent();

        void SwitchToFrame(Element frameElement);
    }
}
