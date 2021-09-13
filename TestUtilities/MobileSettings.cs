using System;
using System.Collections.Generic;
using System.Text;

namespace TestUtilities
{
    public class MobileSettings
    {
        public bool ShouldStartAppiumLocalService { get; set; } = true;

        public string AppiumServiceUrl { get; set; }

        public int SleepInterval { get; set; } = 1000;

        public int ElementToBeVisibleTimeout { get; set; } = 30000;

        public int ElementToExistTimeout { get; set; } = 30000;

        public int ElementToNotExistTimeout { get; set; } = 10000;

        public int ElementToBeClickableTimeout { get; set; } = 30000;

        public int ElementNotToBeVisibleTimeout { get; set; } = 10000;

        public int ElementToHaveContentTimeout { get; set; } = 30000;        

        public RemoteServiceSettings BrowserStack { get; set; }
    }

    public class RemoteServiceSettings : RemoteSettings
    {
        public string User { get; set; }
        public string Key { get; set; }
    }

    public class RemoteSettings
    {
        public Uri GridUri { get; set; }
    }
}
