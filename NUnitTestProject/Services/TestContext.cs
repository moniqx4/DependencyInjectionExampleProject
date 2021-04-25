using DataModelLibrary.Enums;

namespace NUnitTestProject.Services
{
    public class TestContext
    {
        public ITestLogger Logger { get; internal set; }

        public string AppVersion { get; internal set; }

        public string TestCategoryName { get; internal set; }

        public Environment Environment { get; internal set; }

        public Teams Team { get; internal set; }

        public string TestName { get; internal set; }

        public string TRTestCaseId { get; internal set; }

        public string TRTestRunId { get; internal set; }

        public bool IsMobile => WebSite.IsMobile;

        public void Close()
        {
            WebSite.Close();
        }

    }

}
