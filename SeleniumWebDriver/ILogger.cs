using System;

namespace SeleniumWebDriver
{
    public interface ILogger
    {
        void LogTestStarting(DriverContext driverContext);

        void LogTestEnding(DriverContext driverContext);

        void Info(string message, params object[] args);

        void Warn(string message, params object[] args);

        void Error(string message, params object[] args);

        void LogError(Exception e);
    }
}
