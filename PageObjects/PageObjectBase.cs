using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver;
using SeleniumWebDriver.Base;
using SeleniumWebDriver.Type;
using SeleniumWebDriver.WebElements;
using System;

namespace DependencyInjectionExampleProject.PageObjects
{
    public partial class PageObjectBase : BasePage
    {
        public PageObjectBase()
        {
            PageObjectProvider.Setup();
        }
    }
        
   
}
