using NLog;

namespace NUnitTestProject.Services
{
    public class TestLogger: ITestLogger
    {
        private readonly ILogger _logger;

        public TestLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void LogTest(string testname, string message)
        {

            _logger.Debug($"TestName: {testname} - Message: {message}");

        }

        public void LogTest(string testname)
        {

            _logger.Debug($"TestName: {testname}");

        }
    }
}
