using OpenQA.Selenium;
using System;

namespace SeleniumWebDriver.Type
{
    public class ErrorDetail
    {

        private readonly DateTime _dateTime;
        private readonly Exception _exception;
        private readonly Screenshot _screenshot;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetail" /> class.
        /// </summary>
        /// <param name="screenshot">The screenshot.</param>
        /// <param name="dateTime">The date time.</param>
        /// <param name="exception">The exception.</param>
        public ErrorDetail(Screenshot screenshot, DateTime dateTime, Exception exception)
        {
            _screenshot = screenshot;
            _dateTime = dateTime;
            _exception = exception;
        }
    }
}
