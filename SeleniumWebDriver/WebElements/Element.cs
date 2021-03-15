using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace SeleniumWebDriver.WebElements
{
    public class Element : IWebElement
    {
        private readonly IWebElement _element;

        public readonly string Name;

        public By FoundBy { get; set; }
        public Element(IWebElement element, string name)
        {
            _element = element;
            Name = name;
        }

        public IWebElement SeleniumDriver => _element ?? throw new System.NullReferenceException();

        public string TagName => SeleniumDriver.TagName;

        public string Text => SeleniumDriver.Text;

        public bool Enabled => SeleniumDriver.Enabled;

        public bool Selected => SeleniumDriver.Selected;

        public Point Location => SeleniumDriver.Location;

        public Size Size => SeleniumDriver.Size;

        public bool Displayed => SeleniumDriver.Displayed;

        public void Clear()
        {
            SeleniumDriver.Clear();
        }

        public void Click()
        {
            //implement when logging is setup
            // Log.Step($"Click {Name}");
            // everytime something is clicked, it will write a log entry
            SeleniumDriver.Click();
        }

        public IWebElement FindElement(By by)
        {
            return SeleniumDriver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return SeleniumDriver.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            return SeleniumDriver.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return SeleniumDriver.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return SeleniumDriver.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            SeleniumDriver.SendKeys(text);
        }

        public void Submit()
        {
            SeleniumDriver.Submit();
        }
    }
}
