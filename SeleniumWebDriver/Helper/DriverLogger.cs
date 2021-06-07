using System;
using System.Globalization;
using NLog;

namespace SeleniumWebDriver.Helper
{

    public class DriverLogger : IDriverLogger
    {        
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private DateTime startTestTime;
        
        /// <summary>
        /// Logs the test starting.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestStarting(IDriver driverContext, string testTitle)
        {
            startTestTime = DateTime.Now;
            Info("*************************************************************************************");
            Info($"START: {testTitle} starts at {startTestTime}.");
        }

        /// <summary>
        /// Logs the test ending.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestEnding(IDriver driverContext, string testTitle)
        {
            var endTestTime = DateTime.Now;
            var timeInSec = (endTestTime - this.startTestTime).TotalMilliseconds / 1000d;
            Info($"END: {testTitle} ends at {endTestTime} after {timeInSec.ToString("##,###", CultureInfo.CurrentCulture)} sec.");
            Info("*************************************************************************************");
        }

        /// <summary>
        /// Information the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Info(string message, params object[] args)
        {
            Logger.Info(CultureInfo.CurrentCulture, message, args);
        }

        /// <summary>
        /// Warns the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Warn(string message, params object[] args)
        {
            Logger.Warn(CultureInfo.CurrentCulture, message, args);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Error(string message, params object[] args)
        {
            Logger.Error(CultureInfo.CurrentCulture, message, args);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Debug(string message, params object[] args)
        {
            Logger.Debug(CultureInfo.CurrentCulture, message, args);
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="e">The e.</param>
        public void LogError(Exception e)
        {
            Error("Error occurred: {0}", e);
            throw e;
        }
    }
}
