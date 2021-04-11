using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Helper
{

    /// <summary>
    /// Contains wait methods with timeouts.
    /// </summary>
    public static class WaitHelper
    {
        /// <summary>
        /// Wait for a condition with given timeout.
        /// </summary>
        /// <param name="condition">The condition to be met.</param>
        /// <param name="timeout">The timeout value [seconds] indicating how long to wait for the condition.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="WaitTimeoutException">Timeout exception when condition is not met.</exception>
        /// <example>How to use it: <code>
        /// WaitHelper.Wait(() => CountFiles(folder, type) > filesNumber, TimeSpan.FromSeconds(waitTime), timeoutMessage);
        /// </code></example>
        public static void Wait(Func<bool> condition, TimeSpan timeout, string message)
        {
            Wait(condition, timeout, TimeSpan.FromSeconds(1), message);
        }

        /// <summary>
        /// Wait for a condition with given timeout and timeInterval.
        /// </summary>
        /// <param name="condition">The condition to be met.</param>
        /// <param name="timeout">The timeout value [seconds] indicating how long to wait for the condition.</param>
        /// <param name="sleepInterval">The value [seconds] indicating how often to check for the condition to be true.</param>
        /// <param name="message">The exception message.</param>
        /// <exception cref="WaitTimeoutException">Timeout exception when condition is not met.</exception>
        /// <example>How to use it: <code>
        /// WaitHelper.Wait(() => CountFiles(folder, type) > filesNumber, TimeSpan.FromSeconds(waitTime), TimeSpan.FromSeconds(1), timeoutMessage);
        /// </code></example>
        public static void Wait(Func<bool> condition, TimeSpan timeout, TimeSpan sleepInterval, string message)
        {
            var result = Wait(condition, timeout, sleepInterval);

            if (!result)
            {
                throw new WaitTimeoutException(string.Format(CultureInfo.CurrentCulture, "Timeout after {0} second(s), {1}", timeout.TotalSeconds, message));
            }
        }

        /// <summary>
        /// Wait for a condition with given timeout and timeInterval.
        /// </summary>
        /// <param name="condition">The condition to be met.</param>
        /// <param name="timeout">The timeout value [seconds] indicating how long to wait for the condition.</param>
        /// <param name="sleepInterval">The value [seconds] indicating how often to check for the condition to be true.</param>
        /// <returns>
        /// True if condition is met in given timeout.
        /// </returns>
        /// <example>How to use it: <code>
        /// bool result = WaitHelper.Wait(() => CountFiles(folder, type) > filesNumber, TimeSpan.FromSeconds(waitTime), TimeSpan.FromSeconds(1));
        /// </code></example>
        public static bool Wait(Func<bool> condition, TimeSpan timeout, TimeSpan sleepInterval)
        {
            var result = false;
            var start = DateTime.Now;
            var canceller = new CancellationTokenSource();
            var task = Task.Factory.StartNew(condition, canceller.Token);

            while ((DateTime.Now - start).TotalSeconds < timeout.TotalSeconds)
            {
                if (task.IsCompleted)
                {
                    if (task.Result)
                    {
                        result = true;
                        canceller.Cancel();
                        break;
                    }

                    task = Task.Factory.StartNew(
                        () =>
                        {
                            using (canceller.Token.Register(Thread.CurrentThread.Abort))
                            {
                                return condition();
                            }
                        },
                        canceller.Token);
                }

                Thread.Sleep(sleepInterval);
            }

            canceller.Cancel();
            canceller.Dispose();
            return result;
        }
    }
}
