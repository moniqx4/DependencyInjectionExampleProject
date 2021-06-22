using NUnit.Framework;
using SeleniumWebDriver;
using DataModelLibrary;
using DataModelLibrary.Enums;
using Microsoft.Extensions.Configuration;
using TestUtilities;
using NLog.Fluent;
using System.IO;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public class TestSetupTeardown
    {

        [SetUpFixture]
        public class TestSetupTearDown
        {
            private static IConfiguration _configuration;

            private static Checkpoint _checkpoint;
           
            // this is for the stuff that runs one time for the entire test suite         

            [OneTimeSetUp]
            public void RunBeforeAny()
            {
                

                //Configuration for the tests run goes here
                var builder = new ConfigurationBuilder()
                    
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .AddEnvironmentVariable();

                _configuration = builder.Build();

                //var startup = new Startup(_configuration);

                
                //var config = new ConfigurationBuilder()
                //            .AddJsonFile("AppConfig.json")
                //                .Build();

                string environment = _configuration["Environment"];

                //clearing screen shots 
                //clearScreenShots();

                //Setting test environment
                if (environment.Equals("TIN"))
                    EnvironmentConfig.setTestEnvironment(Environment.TIN);
                else if (environment.Equals("BRONZE"))
                    EnvironmentConfig.setTestEnvironment(Environment.BRONZE);
                else if (environment.Equals("CARBON"))
                    EnvironmentConfig.setTestEnvironment(Environment.CARBON);
                else if (environment.Equals("DRPOD"))
                    EnvironmentConfig.setTestEnvironment(Environment.DRPROD);


                //Set Base URL for the APP
                BaseUrl.Url = EnvironmentConfig.TestEnvironment();

                //Set DB Connection strings
                DBConnectionStrings.DBConnectionStr = EnvironmentConfig.TestEnvironment;

                //Initialize Log File
                //SeleniumDriver.CreateLog("Logs ");

                //Initialize Reports
                //reportInitalize();

                _scopeFactory = ServiceProvider.Setup();

                //checkpoint is for resetting of database
                _checkpoint = new Checkpoint
                {

                };
            }

            public static async Task AddAsync<TEntity>(TEntity entity)
                where TEntity : class
            {
                using var scope = _scopeFactory.CreateScope();

                var context.Add(entity);

                await context.SaveChangesAsync();
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
