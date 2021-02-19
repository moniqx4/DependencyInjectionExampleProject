using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver.Models
{
    public class BrowserSettings
    {
        public bool IsMaximized { get; set; }
        public bool IsHeadless { get; set; }
        public string PageLoadStrategy { get; set; }
    }
}
