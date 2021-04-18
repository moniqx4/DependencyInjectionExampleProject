using SeleniumWebDriver;

namespace NUnitTestProject.Services
{
    public class TestContext
    {
        public NLog.ILogger Logger { get; internal set; }

        public string WorkflowName { get; set; }

        public string TRTestCaseId { get; set; }

        public string TRTestRunId { get; set; }

        //public bool IsMobile => WebSite.IsMobile;

        //public void Close()
        //{
        //    WebSite.Close();
        //}

    }

}
