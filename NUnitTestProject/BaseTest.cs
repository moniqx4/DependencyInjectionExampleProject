using DataModelLibrary;
using DataModelLibrary.Enums;
using NUnit.Framework;
using System.Threading.Tasks;
using TestRunnerLibrary;
using TestContext = TestRunnerLibrary.TestContext;

namespace NUnitTestProject
{
    using static TestSetupTeardown;

    public class BaseTest
    {
        
        
       [SetUp]
       public async Task Setup()
        {

            // This would be for resetting the state of the database
           // await ResetState();
        }


        public TestContext SetTestContext(string testName)
        {
            var testContextBuilder = new TestContextBuilder();

            var testContext = testContextBuilder.Build();

            testContext.BrowserType = BrowserType.Chrome;
            testContext.TestName = testName;
            testContext.Team = Teams.TCT;
            testContext.RunType = RunType.Local;
            testContext.StartUrl = "";
            testContext.Active = true;
            testContext.ConfigName = "Default Config";
            testContext.Environment = Environment.TIN;
            testContext.TestCategoryName = "";


            return testContext;
        }

    }
}
