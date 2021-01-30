using NUnit.Framework;
using SeleniumWebDriver;

namespace NUnitTestProject
{
    public class TestSetupTeardown
    {

        [SetUpFixture]
        public class TestSetupTearDown
        {
            private readonly DriverContext driverContext = new DriverContext();
            //DriverContext.CurrentDirectory = Directory.GetCurrentDirectory(); //.net4.x
            //DriverContext.CurrentDirectory = TestContext.CurrentContext.TestDirectory; .netcore3.x
            protected DriverContext DriverContext
            {
                get
                {
                    return driverContext;
                }
            }
            // this is for the stuff that runs one time for the entire test suite
            [OneTimeSetUp]
            public void RunBeforeAnyTests()
            {
                DriverContext.Start();
                //LogTest.LogTestStarting(driverContext);
                PageObjectProvider.Setup();
            }

            /// <summary>
            /// After the test.
            /// </summary>
            //[TearDown]
            //public void AfterTest()
            //{
            //    this.DriverContext.IsTestFailed = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed || !this.driverContext.VerifyMessages.Count.Equals(0);
            //    var filePaths = this.SaveTestDetailsIfTestFailed(this.driverContext);
            //    this.SaveAttachmentsToTestContext(filePaths);
            //    this.LogTest.LogTestEnding(this.driverContext);
            //    var javaScriptErrors = this.DriverContext.LogJavaScriptErrors();
            //    if (this.IsVerifyFailedAndClearMessages(this.driverContext) && TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
            //    {
            //        Assert.Fail();
            //    }

            //    if (javaScriptErrors)
            //    {
            //        Assert.Fail("JavaScript errors found. See the logs for details");
            //    }
            //}

        }
    }
}
