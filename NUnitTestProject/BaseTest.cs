using DataModelLibrary;
using DataModelLibrary.Enums;
using TestRunnerLibrary;


namespace NUnitTestProject
{
    public abstract class BaseTest
    {
        
        public BaseTest()
        {
            
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
