using DataModelLibrary;


namespace SeleniumWebDriver.Drivers
{
    public class SeleniumConfiguration
    {
        public string Name { get; set; }

        public bool Active { get; set; }

        public string Browser { get; set; }

        ///public string Version { get; set; } probably always use the latest, but if we end up using browserstack, could select earlier versions

        public bool IsMobile { get; set; }

        public bool Headless { get; set; }

        public RunType RunType { get; set; }

        //public List<SeleniumCapability> Capabilities { get; set; }

    }
}
