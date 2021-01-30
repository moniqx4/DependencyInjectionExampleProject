using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public interface IDriverContext
    {
        void Start();

        Screenshot TakeScreenshot();

    }
}
