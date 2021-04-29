namespace AutomationServices.SharedServices.BrowserActions
{
    public interface IBrowserActions
    {

        void NavigateToPageUrl(string url);
        void CloseBrowser();

        void ReLoadPage();

    }
}
