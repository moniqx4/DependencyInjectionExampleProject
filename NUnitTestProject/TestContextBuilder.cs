namespace NUnitTestProject
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
            _context.TestName = testName;

            return this;
        }

        public TestContextBuilder AddVersion(string version)
        {
            _context.Version = version;

            return this;
        }

        public TestContext Build()
        {
            return _context;
        }
    }
}
