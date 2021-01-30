using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SeleniumWebDriver.Helper
{
    /// <summary>
    /// Contains handle to driver and methods for web browser.
    /// </summary>
    public partial class DriverContextHelper
    {
        //public string SaveScreenshot(ErrorDetail errorDetail, string folder, string title)
        //{
        //    var fileName = string.Format(CultureInfo.CurrentCulture, "{0}_{1}_{2}.png", title, errorDetail.DateTime.ToString("yyyy-MM-dd HH-mm-ss-fff", CultureInfo.CurrentCulture), "browser");
        //    var correctFileName = Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(CultureInfo.CurrentCulture), string.Empty));
        //    correctFileName = Regex.Replace(correctFileName, "[^0-9a-zA-Z._]+", "_");
        //    correctFileName = NameHelper.ShortenFileName(folder, correctFileName, "_", 255);

        //    var filePath = Path.Combine(folder, correctFileName);

        //    try
        //    {
        //        errorDetail.Screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        //        FilesHelper.WaitForFileOfGivenName(BaseConfig.ShortTimeout, correctFileName, folder);
        //        //Logger.Error(CultureInfo.CurrentCulture, "Test failed: screenshot saved to {0}.", filePath);
        //        Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "##teamcity[publishArtifacts '{0}']", filePath));
        //        return filePath;
        //    }
        //    catch (NullReferenceException)
        //    {
        //        //Logger.Error("Test failed but was unable to get webdriver screenshot.");
        //    }

        //    return null;
        //}

        /// <summary>
        /// Takes and saves screen shot.
        /// </summary>
        /// <returns>Array of filepaths.</returns>
        //public string[] TakeAndSaveScreenshot()
        //{
        //    List<string> filePaths = new List<string>();


        //    if (BaseConfig.SeleniumScreenShotEnabled)
        //    {
        //        filePaths.Add(this.SaveScreenshot(new ErrorDetail(this.TakeScreenshot(), DateTime.Now, null), this.ScreenShotFolder, this.TestTitle));
        //    }

        //    return filePaths.ToArray();
        //}

        /// <summary>
        /// Logs JavaScript errors.
        /// </summary>
        /// <returns>True if JavaScript errors found.</returns>
        //public bool LogJavaScriptErrors()
        //{
        //    IEnumerable<LogEntry> jsErrors = null;
        //    bool javScriptErrors = false;

        //    // Check JavaScript browser logs for errors.
        //    if (BaseConfig.JavaScriptErrorLogging)
        //    {
        //        Logger.Debug(CultureInfo.CurrentCulture, "Checking JavaScript error(s) in browser");
        //        try
        //        {
        //            jsErrors =
        //                this.driver.Manage()
        //                    .Logs.GetLog(LogType.Browser)
        //                    .Where(x => BaseConfig.JavaScriptErrorTypes.Any(e => x.Message.Contains(e)));
        //        }
        //        catch (NullReferenceException)
        //        {
        //            Logger.Error(CultureInfo.CurrentCulture, "NullReferenceException while trying to read JavaScript errors from browser.");
        //            return false;
        //        }

        //        if (jsErrors.Any())
        //        {
        //            // Show JavaScript errors if there are any
        //            Logger.Error(CultureInfo.CurrentCulture, "JavaScript error(s): {0}", Environment.NewLine + jsErrors.Aggregate(string.Empty, (s, entry) => s + entry.Message + Environment.NewLine));
        //            javScriptErrors = true;
        //        }
        //    }

        //    return javScriptErrors;
        //}
    }
}
