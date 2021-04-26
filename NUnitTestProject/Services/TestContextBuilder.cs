using DataModelLibrary.Enums;

namespace NUnitTestProject.Services
{
    public class TestContextBuilder
    {
        private readonly TestContext _context;        

        public TestContextBuilder()
        {
            _context = new TestContext();
           
        }

        public TestContextBuilder AddWebSiteContext(WebSiteContext webSiteContext)
        {
            _context.WebSite = webSiteContext;

            return this;
        }

        public TestContextBuilder AddLogger()
        {
            _context.Logger = logger;

            return this;
        }

        //public TestContextBuilder AddAppVersion()
        //{
        //    _context.AppVersion = appVersion;

        //    return this;
        //}

        public TestContextBuilder AddTestName(string testName)
        {
            _context.TestName = testName;

            return this;
        }

        public TestContextBuilder AddTeam(Teams team)
        {
            _context.Team = team;

            return this;
        }

        public TestContextBuilder AddTRTestcaseId(string trTestCaseId)
        {
            _context.TRTestCaseId = trTestCaseId;

            return this;
        }

        public TestContextBuilder AddTRTestRunId(string trTestRunId)
        {
            _context.TRTestRunId = trTestRunId;

            return this;
        }

        public TestContextBuilder AddTestCategory(string testCategory)
        {
            _context.TestCategoryName = testCategory;

            return this;
        }

        public TestContextBuilder AddEnvironment(Environment environment)
        {
            _context.Environment = environment;

            return this;
        }


        public TestContext Build()
        {
            return _context;
        }
    }
}
