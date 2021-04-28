using DataModelLibrary.Enums;
using TestRunnerLibrary;


namespace NUnitTestProject
{
    public class BaseTest
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


            //TestContext testContext = new TestContext
            //{
            //    testContextBuilder.AddBrowser(BrowserType.Chrome);
            //    testContextBuilder.AddTestName(testName);
            //};



            return testContext;
        }

    }
}
