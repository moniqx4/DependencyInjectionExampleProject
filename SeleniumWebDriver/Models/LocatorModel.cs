using SeleniumWebDriver.Type;

namespace SeleniumWebDriver.Models
{
    public class LocatorModel
    {
        public LocatorType LocatorType { get; set; }
        public string Locator { get; set; }
        public ElementType ElementType { get; set; }
    }
}
