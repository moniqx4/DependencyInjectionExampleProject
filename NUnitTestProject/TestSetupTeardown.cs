using Microsoft.Extensions.Configuration;
using NLog.Fluent;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver;
using SeleniumWebDriver.Types;
using TestUtilities;
using System.Reflection;
using System.Threading;
using System.IO;

namespace NUnitTestProject
{
    public class TestSetupTeardown
    {

        [SetUpFixture]
        public class TestSetupTearDown
        {
            // this is for the stuff that runs one time for the entire test suite
            [SetUp]
            public virtual void BeforeEach()
            {
                // TODO: setup logger here, once created
                //    Log.Information("");
                //    Log.Information("\nNew Test Cycle :");
                PageObjectProvider.Setup(); // this is what sets up our container for the PageObjects  
                // TODO: create one to create and register the browser container, ex. UnityContainerFactory.GetContainer().RegisterInstance<IWebDriver>(SeleniumDriver.Browser);
                SeleniumDriver.Build("local", BrowserType.Chrome);                             
            }

            [OneTimeSetUp]
            public virtual void RunBeforeAll()
            {
                //Configuration for the tests run goes here
                //var config = new ConfigurationBuilder()
                //            .AddJsonFile("AppConfig.json")
                //                .Build();

                //string environment = config["Environment"];

                //clearing screen shots 
                //clearScreenShots();

                //Setting test environment
                //if (environment.Equals("TIN"))
                //    EnvironmentConfig.setTestEnvironment(Environment.TIN);
                //else if (environment.Equals("BRONZE"))
                //    EnvironmentConfig.setTestEnvironment(Environment.BRONZE);
                //else if (environment.Equals("CARBON"))
                //    EnvironmentConfig.setTestEnvironment(Environment.CARBON);
                //else if (environment.Equals("DRPOD"))
                //    EnvironmentConfig.setTestEnvironment(Environment.DRPROD);

                //Set Base URL for the APP
                //BaseUrl.SetBaseUrl(EnvironmentConfig.TestEnvironment);

                //Set DB Connection strings
                //DBConnectionStrings.SetDBConnectionString(EnvironmentConfig.TestEnvironment);

                //Initialize Log File
                //SeleniumDriver.CreateLog("Logs ");

                //Initialize Reports
                //reportInitalize();
            }

            /// <summary>
            /// After the test.
            /// </summary>
            [TearDown]
            public void AfterTest()
            {
                //Log.CloseAndFlush();
                //extent.Flush();
                SeleniumDriver.StopBrowser();
            }

        }
    }
}
