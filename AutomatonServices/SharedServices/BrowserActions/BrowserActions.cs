using SeleniumWebDriver;

namespace AutomationServices.SharedServices.BrowserActions
{
    
    public class BrowserActions
    {

        private readonly IBrowser _browser;
        public BrowserActions(IBrowser browser)
        {
            _browser = browser;
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
    }
}
