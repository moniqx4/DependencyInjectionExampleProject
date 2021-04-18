using SeleniumWebDriver;

namespace NUnitTestProject.Services
{
    public class WebSiteContextBuilder
    {
        private readonly WebSiteContext _context;

        public WebSiteContextBuilder()
        {
            _context = new WebSiteContext();
        }


        public WebSiteContextBuilder AddSiteUrl(string siteUrl)
        {
            _context.SiteUrl = siteUrl;

            return this;
        }

        public WebSiteContextBuilder AddMobileFlag(bool isMobile)
        {
            _context.IsMobile = isMobile;

            return this;
        }

        public WebSiteContextBuilder AddBrowser(IBrowser browser)
        {
            _context.Browser = browser;

            return this;
        }

        public WebSiteContextBuilder AddWebPageHandler(IWebPage webPage)
        {
            _context.WebPage = webPage;

            return this;
        }

        public WebSiteContext Build()
        {
            return _context;
        }


    }
}
