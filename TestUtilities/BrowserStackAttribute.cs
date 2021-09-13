using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium;

namespace TestUtilities
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public abstract class BrowserStackAttribute : AppAttribute, IAppiumOptionsFactory
    {
        protected BrowserStackAttribute(
            string appPath,
            string platformVersion,
            string deviceName,
            AppBehavior behavior = AppBehavior.NotSet,
            bool captureVideo = false,
            bool captureNetworkLogs = false,
            BrowserStackConsoleLogType consoleLogType = BrowserStackConsoleLogType.Disable,
            bool debug = false,
            string build = null)
            : base(appPath, platformVersion, deviceName, behavior)
        {
            Debug = debug;
            Build = build;
            CaptureVideo = captureVideo;
            CaptureNetworkLogs = captureNetworkLogs;
            ConsoleLogType = consoleLogType;
            AppConfiguration.ExecutionType = ExecutionType.BrowserStack;
        }

        public bool Debug { get; }

        public string Build { get; }

        public bool CaptureVideo { get; }

        public bool CaptureNetworkLogs { get; }

        public BrowserStackConsoleLogType ConsoleLogType { get; }

        public AppiumOptions CreateAppiumOptions(MemberInfo memberInfo, Type testClassType)
        {
            var appiumOptions = new AppiumOptions();
            AddAdditionalCapabilities(testClassType, appiumOptions);

            appiumOptions.AddAdditionalCapability("browserstack.debug", Debug);

            if (!string.IsNullOrEmpty(Build))
            {
                appiumOptions.AddAdditionalCapability("build", Build);
            }

            appiumOptions.AddAdditionalCapability("device", AppConfiguration.DeviceName);
            appiumOptions.AddAdditionalCapability("os_version", AppConfiguration.PlatformVersion);
            appiumOptions.AddAdditionalCapability("app", AppConfiguration.AppPath);
            appiumOptions.AddAdditionalCapability("browserstack.video", CaptureVideo);
            appiumOptions.AddAdditionalCapability("browserstack.networkLogs", CaptureNetworkLogs);
            string consoleLogTypeText = Enum.GetName(typeof(BrowserStackConsoleLogType), ConsoleLogType)?.ToLower();
            appiumOptions.AddAdditionalCapability("browserstack.console", consoleLogTypeText);

            var browserStackCredentialsResolver = new BrowserStackCredentialProvider();
            var credentials = browserStackCredentialsResolver.GetCredentials();
            appiumOptions.AddAdditionalCapability("browserstack.user", credentials.Item1);
            appiumOptions.AddAdditionalCapability("browserstack.key", credentials.Item2);

            return appiumOptions;
        }
    }
}
