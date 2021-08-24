using SeleniumWebDriver.Helper;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System;
using System.Drawing;

namespace SeleniumWebDriver.ConcreteClasses
{
    public class DriverEventListener: IWebDriver, ISearchContext, IDisposable, IWebElement
    {
        private IDriverLogger _logger = new DriverLogger();

        private static IWebDriver _driver;

        private IWebElement _webElement;
        private bool disposedValue;

        private EventFiringWebDriver _eventFiringDriver = new EventFiringWebDriver(_driver);

        public DriverEventListener()
        {
            
        }

        public event EventHandler<WebDriverNavigationEventArgs> Navigating;

        public event EventHandler<WebDriverNavigationEventArgs> NavigatingBack;

        public event EventHandler<WebDriverNavigationEventArgs> NavigatedBack;

        public event EventHandler<WebDriverNavigationEventArgs> NavigatingForward;

        public event EventHandler<WebDriverNavigationEventArgs> NavigatedForward;

        public event EventHandler<WebElementEventArgs> ElementClicking;

        public event EventHandler<WebElementEventArgs> ElementClicked;

        public event EventHandler<WebElementEventArgs> ElementValueChanging;

        public event EventHandler<WebElementEventArgs> ElementValueChanged;

        public event EventHandler<WebElementEventArgs> FindingElement;

        public event EventHandler<WebElementEventArgs> FindElementComplete;

        public event EventHandler<WebElementEventArgs> FoundElement;

        public event EventHandler<WebDriverScriptEventArgs> ScriptExecuting;

        public event EventHandler<WebDriverScriptEventArgs> ScriptExecuted;

        public event EventHandler<WebDriverExceptionEventArgs> ExceptionThrown;

        //public EventFiringWebDriver(IWebDriver parentDriver)
        //{
        //    _browser = parentDriver;
        //}

        public string Url { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string Title => throw new System.NotImplementedException();

        public string PageSource => throw new System.NotImplementedException();

        public string CurrentWindowHandle => throw new System.NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new System.NotImplementedException();

        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void BeforeAlertAccept()
        {
            
        }

        //public EventFiringWebDriver BeforeNavigateTo(string url)
        //{
        //    _logger.Info($"Before Navigating to url: {url}");

        //    EventFiringWebDriver _eventFiringListener = new EventFiringWebDriver(_browser);

        //    EventListener _eventListener = new EventListener();

        //    _eventListener = _eventFiringListener.Navigate().GoToUrl(url);

        //    return _eventListener;


        //}

        public void Close()
        {
            try
            {
                _eventFiringDriver.Close();
                
            }
            catch (Exception ex)
            {
                new WebDriverExceptionEventArgs(_driver, ex);                
            }

           
        }

        public IWebElement FindElement(By by)
        {
            throw new System.NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new System.NotImplementedException();
        }

        public IOptions Manage()
        {
            throw new System.NotImplementedException();
        }

        public INavigation Navigate()
        {
            
            throw new System.NotImplementedException();
        }

        public void Quit()
        {
            throw new System.NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~DriverEventListener()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }

        public void Clear(By by)
        {
            _eventFiringDriver.FindElement(by).Clear();
        }

        public void SendKeys(By by,string text)
        {
            _eventFiringDriver.FindElement(by).SendKeys(text);            
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void Click(By by)
        {
            _eventFiringDriver.FindElement(by).Click();            
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
