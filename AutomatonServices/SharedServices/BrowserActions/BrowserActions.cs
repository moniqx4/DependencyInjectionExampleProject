using PageObjects.Shared;
using SeleniumWebDriver;

namespace AutomationServices.SharedServices.BrowserActions
{
    
    public class BrowserActions
    {

        private readonly IBrowser _browser;
        private readonly IBrowserHandler _browserHandler;
        public BrowserActions(IBrowser browser, IBrowserHandler browserHandler)
        {
            _browser = browser;
            _browserHandler = browserHandler;
        }

        public void NavigateToPageUrl(string url)
        {
            _browser.NavigateTo(url);
        }

        public void CloseBrowser()
        {
            _browser.Close();
            
        }

        public void ReLoadPage()
        {
            _browser.BrowserRefresh();

        }

        public void NavForward()
        {
            _browserHandler.Browser().Navigate().Forward();
        }
    }
}
