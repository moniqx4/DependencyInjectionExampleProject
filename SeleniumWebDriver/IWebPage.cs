using SeleniumWebDriver.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject.SeleniumWebDriver
{
    public interface IWebPage
    {
        void ClickElement(Locator locator);
    }
}
