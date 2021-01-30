using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver.Type
{
    public class ErrorDetail
    {

        private DateTime _dateTime;
        private Exception _exception;
        private Screenshot _screenshot;

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
