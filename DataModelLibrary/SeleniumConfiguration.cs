using DataModelLibrary.Enums;
using System.Collections.Generic;

namespace DataModelLibrary
{
    public class SeleniumConfiguration
    {

        public SeleniumConfiguration(string configName, bool active, BrowserType browserType, bool isMobileEnabled, IReadOnlyList<MobileDevices> mobileDevices, bool headless, string startUrl
            , string testName, RunType runType, Environment environment, Teams teams, string testCategory)
        {
            ConfigName = configName;
            Active = active;
            BrowserType = browserType;
            IsMobileEnabled = isMobileEnabled;
            MobileDevices = mobileDevices;
            Headless = headless;
            StartUrl = startUrl;
            TestName = testName;
            RunType = runType;
            Environment = environment;
            Teams = teams;
            TestCategory = testCategory;
        }

        public string ConfigName { get;}

        public bool Active { get; }

        public BrowserType BrowserType { get; }

        ///public string AppVersion { get; set; } probably always use the latest, but if we end up using browserstack, could select earlier versions

        public bool IsMobileEnabled { get;  }

        public IReadOnlyList<MobileDevices> MobileDevices { get; }

        public bool Headless { get; }

        public string StartUrl { get; }

        public string TestName { get; }

        public RunType RunType { get;  }

        public Environment Environment { get;  }

        public Teams Teams { get;  }

        public string TestCategory { get;  }

        //public List<SeleniumCapability> Capabilities { get; set; }

    }
}
