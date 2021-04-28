using DataModelLibrary;
using DataModelLibrary.Enums;
using SeleniumWebDriver;
using SeleniumWebDriver.Drivers;
using System.Collections.Generic;

namespace TestRunnerLibrary
{
    public class TestContext
    {
        //public ILogService Logger { get; internal set; } // for TestRunner

        public string AppVersion { get; set; } // information to log

        public string TestCategoryName { get; set; } // for Tests, configuration setting

        public Environment Environment { get; set; } // for Driver ( determines which StartUrl to use and for TestRunner, configuration setting

        public Teams Team { get; set; } // for Tests, configuration setting

        public string TestName { get; set; } // for Tests

        public string TRTestCaseId { get; set; } // for Tests

        public string TRTestRunId { get; set; } // for Tests       

        public string ConfigName { get; set; } // to allow the selection of configurations by name, configuration setting

        public bool Active { get; set; } // to set a particular configuration as active, configuration setting

        /* Items specifically for setting the Driver */

        public string StartUrl { get; set; } // for Driver

        public bool IsMobile { get; set; } // for Driver, configuration setting

        public string ViewPort { get; set; } // for Driver, configuration setting

        public BrowserType BrowserType { get; set; } // for Driver , configuration setting       

        public MobileDevices MobileDevice { get; set; } // for Driver , configuration setting

        public bool Headless { get; set; } // for Driver, configuration setting

        public RunType RunType { get; set; } // for Driver , configuration setting       

        public List<SeleniumCapability> Capabilities { get; set; } // for Driver, configuration setting

        public IDriver Driver { get; internal set; } // for Driver        

        public void Close() // for Driver
        {
            Driver.Close();
        }

    }

}
