namespace DependencyInjectionExampleProject.Tests
{
    public class TestContextBuilder
    {
        private readonly TestContext _context;

        public TestContextBuilder()
        {
            _context = new TestContext();
        }

        //public TestContextBuilder AddLogger(ILogger logger)
        //{
        //    _context.Logger = logger;

        //    return this;
        //}

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
