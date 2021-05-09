using DataModelLibrary;
using DataModelLibrary.Enums;
using SeleniumWebDriver;

namespace TestRunnerLibrary
{
    public class TestContextBuilder
    {
        private readonly TestContext _context;
        
        public TestContextBuilder()
        {
            
            _context = new TestContext();

        }

        //public TestContextBuilder AddLogger()
        //{
        //    _context.Logger = logger;

        //    return this;
        //}

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

        public TestContextBuilder AddStartUrl(string startUrl)
        {
            _context.StartUrl = startUrl;

            return this;
        }

        public TestContextBuilder AddMobileFlag(bool isMobile)
        {
            _context.IsMobile = isMobile;

            return this;
        }

        public TestContextBuilder AddViewPort(int width, int height)
        {

            _context.ViewPort = new ViewPort
            {
                Width = width,
                Height = height
            };            

            return this;
        }

        public TestContextBuilder AddBrowser(BrowserType browserType)
        {
            _context.BrowserType = browserType;

            return this;
        }

        public TestContextBuilder AddDriverHandler(IDriver driver)
        {
            _context.Driver = driver;

            return this;
        }

        public TestContextBuilder CloseBrowser()
        {

            _context.Close();

            return this;
        }


        public TestContext Build()
        {
            return _context;
        }
    }
}
