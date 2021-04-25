using System;

namespace SeleniumWebDriver
{
    public interface IDriverLogger
    {
        void LogTestStarting(IDriver driverContext, string testTitle);

        void LogTestEnding(IDriver driverContext, string testTitle);

        void Info(string message, params object[] args);

        void Warn(string message, params object[] args);

        void Error(string message, params object[] args);

        void LogError(Exception e);
    }
}
