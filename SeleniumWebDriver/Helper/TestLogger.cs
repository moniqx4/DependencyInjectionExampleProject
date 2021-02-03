using System;
using System.Globalization;
using NLog;

namespace SeleniumWebDriver.Helper
{

    public class TestLogger : ILogger
    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger(); //.net4.x
        //private static readonly NLog.Logger Logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger(); // netcore3.x
        private DateTime startTestTime;
        
        /// <summary>
        /// Logs the test starting.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestStarting(DriverContext driverContext)
        {
            this.startTestTime = DateTime.Now;
            this.Info("*************************************************************************************");
            this.Info("START: {0} starts at {1}.", driverContext.TestTitle, startTestTime);
        }

        /// <summary>
        /// Logs the test ending.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestEnding(DriverContext driverContext)
        {
            var endTestTime = DateTime.Now;
            var timeInSec = (endTestTime - this.startTestTime).TotalMilliseconds / 1000d;
            this.Info("END: {0} ends at {1} after {2} sec.", driverContext.TestTitle, endTestTime, timeInSec.ToString("##,###", CultureInfo.CurrentCulture));
            this.Info("*************************************************************************************");
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
        /// Logs the error.
        /// </summary>
        /// <param name="e">The e.</param>
        public void LogError(Exception e)
        {
            this.Error("Error occurred: {0}", e);
            throw e;
        }
    }
}
