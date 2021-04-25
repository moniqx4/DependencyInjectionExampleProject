using DataModelLibrary.Enums;
using SeleniumWebDriver.Types;

namespace DataModelLibrary
{
    public class SeleniumConfiguration
    {
        public string ConfigName { get; set; }

        public bool Active { get; set; }

        public BrowserType Browser { get; set; }

        ///public string AppVersion { get; set; } probably always use the latest, but if we end up using browserstack, could select earlier versions

        public bool IsMobile { get; set; }

        public bool IsLocal { get; set; }

        public MobileDevices MobileDevice { get; set; }

        public bool Headless { get; set; }

        public string StartUrl { get; set; }

        public string TestName { get; set; }

        public RunType RunType { get; set; }

        public Environment Environment { get; set; }

        public Teams Team { get; set; }

        public string TestCategory { get; set; }

        //public List<SeleniumCapability> Capabilities { get; set; }

    }
}
