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
                DriverContext.Start();  // Based on what is in the BaseConfig, starts the specifed browsertype
                //LogTest.LogTestStarting(driverContext);
                PageObjectProvider.Setup(); // this is what sets up our container for the PageObjects
                // DriverContext.Goto(url); needs to be the Login Page usually, or whatever page the test starts on
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
