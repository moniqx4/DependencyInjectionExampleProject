namespace NUnitTestProject.Services
{
    public interface ITestLogger
    {
        void LogTest(string testname, string message);

        void LogTest(string testname);
    }
}
