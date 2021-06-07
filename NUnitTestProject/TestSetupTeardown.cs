using NUnit.Framework;
using SeleniumWebDriver;
using DataModelLibrary;
using DataModelLibrary.Enums;

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

                SeleniumConfiguration config = new SeleniumConfiguration
                {
                    //Browser = BrowserType.Chrome,
                };
                // TODO: setup logger here, once created
                //    Log.Information("");
                //    Log.Information("\nNew Test Cycle :");
                ServiceProvider.Setup();                
                // TODO: create one to create and register the browser container, ex. UnityContainerFactory.GetContainer().RegisterInstance<IWebDriver>(SeleniumDriver.Browser);
                                         
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
