using SeleniumWebDriver;

namespace NUnitTestProject.Services
{
    public class WebSiteContext
    {
        public string SiteUrl { get; internal set; }

        public bool IsMobile { get; internal set; }

        public IBrowser Browser { get; internal set; }

        public IWebPage WebPage { get; internal set; }

        internal void Close()
        {
            Browser.Close();
        }
    }
}
