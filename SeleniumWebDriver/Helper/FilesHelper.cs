using NLog;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace SeleniumWebDriver.Helper
{
    public static class FilesHelper
    {
        public static readonly char Separator = Path.DirectorySeparatorChar;
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger(); //.net4.x
        // private static readonly NLog.Logger Logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger(); //.netcore3.x

        /// <summary>
        /// Gets the folder from app.config as value of given key.
        /// </summary>
        /// <param name="appConfigValue">The application configuration value.</param>
        /// <param name="currentFolder">Directory where assembly files are located.</param>
        /// <returns>
        /// The path to folder.
        /// </returns>
        /// <example>How to use it: <code>
        ///   FilesHelper.GetFolder(BaseConfig.DownloadFolder, this.CurrentDirectory);
        /// </code></example>
        public static string GetFolder(string appConfigValue, string currentFolder)
        {
            Logger.Trace(CultureInfo.CurrentCulture, "appConfigValue '{0}', currentFolder '{1}', UseCurrentDirectory '{2}'", appConfigValue, currentFolder, BaseConfig.UseCurrentDirectory);
            string folder;

            if (string.IsNullOrEmpty(appConfigValue))
            {
                folder = currentFolder;
            }
            else
            {
                if (BaseConfig.UseCurrentDirectory)
                {
                    Regex pattern = new Regex("[\\]|[\\\\]|[/]|[//]");
                    appConfigValue = pattern.Replace(appConfigValue, string.Empty);
                    folder = currentFolder + FilesHelper.Separator + appConfigValue;
                }
                else
                {
                    folder = appConfigValue;
                }

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }

            Logger.Trace(CultureInfo.CurrentCulture, "Returned folder '{0}'", folder);
            
            return folder;
        }
    }
}
