using NLog;

namespace NUnitTestProject.Services
{
    public class TestContextBuilder
    {
        private readonly TestContext _context;
        private readonly ITestLogger _logger;

        public TestContextBuilder(ITestLogger logger)
        {
            _context = new TestContext();
            _logger = logger;
        }

        public TestContextBuilder AddLogger()
        {
            _context.Logger = (ILogger)_logger;

            return this;
        }

        public TestContextBuilder AddName(string testName)
        {
            _context.WorkflowName = testName;

            return this;
        }
      

        public TestContext Build()
        {
            return _context;
        }
    }
}
