using DataModelLibrary.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace SeleniumWebDriver.Helper
{
    public static class ElementHighlighter
    {
        public static void Highlight(this IWebElement nativeElement, int waitBeforeUnhighlightMilliseconds = 100, string color = "yellow")
        {
            if (WrappedWebDriverCreateService.BrowserConfiguration.BrowserType == BrowserType.ChromeHeadless || WrappedWebDriverCreateService.BrowserConfiguration.BrowserType == BrowserType.FirefoxHeadless)
            {
                // No need to highlight for headless browsers.
                return;
            }

            try
            {
                var javaScriptService = ServicesCollection.Current.Resolve<JavaScriptService>();
                var originalElementBorder = javaScriptService.Execute("return arguments[0].style.background", nativeElement);
                javaScriptService.Execute($"arguments[0].style.background='{color}'; return;", nativeElement);
                if (waitBeforeUnhighlightMilliseconds >= 0)
                {
                    if (waitBeforeUnhighlightMilliseconds > 1000)
                    {
                        var backgroundWorker = new BackgroundWorker();
                        backgroundWorker.DoWork += (obj, e) => Unhighlight(nativeElement, originalElementBorder, waitBeforeUnhighlightMilliseconds);
                        backgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        Unhighlight(nativeElement, originalElementBorder, waitBeforeUnhighlightMilliseconds);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private static void Unhighlight(IWebElement nativeElement, string border, int waitBeforeUnhighlightMiliSeconds)
        {
            try
            {
                var javaScriptService = ServicesCollection.Current.Resolve<JavaScriptService>();
                Thread.Sleep(waitBeforeUnhighlightMiliSeconds);
                javaScriptService.Execute("arguments[0].style.background='" + border + "'; return;", nativeElement);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
        
}
