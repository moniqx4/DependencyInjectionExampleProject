﻿using Microsoft.Extensions.Configuration;
using SeleniumWebDriver.Types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Configuration;
using NLog;

namespace SeleniumWebDriver
{
    public static class BaseConfig
    {
        // private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger(); .net4.x
        public static readonly string Env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        //ILogger logger = new Logger();

        /// <summary>
        /// Getting appsettings.json file.
        /// </summary>
        public static readonly IConfigurationRoot Builder = new ConfigurationBuilder()
           //TODO:
            //.AddJsonFile("appsettings.json", true, true)
            //.AddJsonFile($"appsettings.{Env}.json", true, true)
            .Build();

        /// <summary>
        /// Gets the url.
        /// </summary>
        public static string Url
        {
            get
            {
               
                //setting = ConfigurationManager.AppSettings["url"];  .net4.x

                string setting = Builder["appSettings:url"]; // .net core3.x
                //ILogger Logger;
                //Logger.Info("Gets the url from settings file '{0}'", setting);
                
                return setting;
            }
        }


        /// <summary>
        /// Gets the Driver.
        /// </summary>       
        public static BrowserType Browser
        {
            get
            {
                      
                //setting = ConfigurationManager.AppSettings["browser"]; .net4.x
                string setting = Builder["appSettings:browser"]; //.netcore

                //ILogger.Info("Browser value from settings file '{0}'", setting);
                bool supportedBrowser = Enum.TryParse(setting, out BrowserType browserType);
                if (supportedBrowser)
                {
                    return browserType;
                }

                return BrowserType.None;
            }
        }

        /// <summary>
        /// Gets a value indicating whether use CurrentDirectory for path where assembly files are located.
        /// </summary>
        public static bool UseCurrentDirectory
        {
            get
            {
               // setting = ConfigurationManager.AppSettings["UseCurrentDirectory"]; .net4.x

                string setting = Builder["appSettings:UseCurrentDirectory"]; //.netcore3.x
                //ILogger logger;
                //logger.Info("Use Current Directory value from settings file '{0}'", setting);
                if (string.IsNullOrEmpty(setting))
                {
                    return false;
                }

                if (setting.ToLower(CultureInfo.CurrentCulture).Equals("true"))
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        public static string Username
        {
            get
            {
               //setting = ConfigurationManager.AppSettings["username"]; .net4.x

                string setting = Builder["appSettings:username"]; //.netcore3.x
                //Logger.Info("Gets the username from settings file '{0}'", setting);

                return setting;
            }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        public static string Password
        {
            get
            {
               //setting = ConfigurationManager.AppSettings["password"]; .net4.x


                string setting = Builder["appSettings:password"]; //.netcore3.x

                //Logger.Trace(CultureInfo.CurrentCulture, "Gets the password from settings file '{0}'", setting);
                return setting;
            }
        }

        /// <summary>
        /// Gets the java script or ajax waiting time [seconds].
        /// </summary>
        /// <example>How to use it: <code>
        /// this.Driver.IsElementPresent(this.statusCodeHeader, BaseConf.MediumTimeout);
        /// </code></example>
        public static double MediumTimeout
        {
            get
            {
             
                //setting = Convert.ToDouble(ConfigurationManager.AppSettings["mediumTimeout"]); .net.4.x

                double setting = Convert.ToDouble(Builder["appSettings:mediumTimeout"]); //.netcore3.x

                //Logger.Info("Gets the mediumTimeout from settings file '{0}'", setting);
                return setting;
            }
        }

        /// <summary>
        /// Gets the page load waiting time [seconds].
        /// </summary>
        /// <example>How to use it: <code>
        /// element.GetElement(locator, BaseConfiguration.LongTimeout, e => e.Displayed, customMessage);
        /// </code></example>
        public static double LongTimeout
        {
            get
            {
                // setting = Convert.ToDouble(ConfigurationManager.AppSettings["longTimeout"]); .net.4.x

                double setting = Convert.ToDouble(Builder["appSettings:longTimeout"]); //.netcore3.x

                //Logger.Info("Gets the longTimeout from settings file '{0}'", setting);
                return setting;
            }
        }

        /// <summary>
        /// Gets the assertion waiting time [seconds].
        /// </summary>
        /// <example>How to use it: <code>
        /// this.Driver.IsElementPresent(this.downloadPageHeader, BaseConf.ShortTimeout);
        /// </code></example>
        public static double ShortTimeout
        {
            get
            {
                //setting = Convert.ToDouble(ConfigurationManager.AppSettings["shortTimeout"]);  .net.4.x

                double setting = Convert.ToDouble(Builder["appSettings:shortTimeout"]); //.netcore3.x

                //Logger.Info("Gets the shortTimeout from settings file '{0}'", setting);
                return setting;
            }
        }

        /// <summary>
        /// Gets the Implicitly Wait time [milliseconds].
        /// </summary>
        public static double ImplicitlyWaitMilliseconds
        {
            get
            {                
                //setting = Convert.ToDouble(ConfigurationManager.AppSettings["ImplicitlyWaitMilliseconds"]); //.net.4.x

                double setting = Convert.ToDouble(Builder["appSettings:ImplicitlyWaitMilliseconds"]); //.netcore3.x

                //Logger.Info("Gets the ImplicitlyWaitMilliseconds from settings file '{0}'", setting);
                return setting;
            }
        }

        //since using the DriverManager, don't need this
        /// <summary>
        /// Gets the path and file name of the Firefox browser executable.
        /// </summary>
        //public static string FirefoxBrowserExecutableLocation
        //{
        //    get
        //    {
        //        //setting = ConfigurationManager.AppSettings["FirefoxBrowserExecutableLocation"];  //.net.4.x

        //        string setting = Builder["appSettings:FirefoxBrowserExecutableLocation"]; //.netcore3.x

        //        //Logger.Info(CultureInfo.CurrentCulture, "Gets the path and file name of the Firefox browser executable from settings file '{0}'", setting);
        //        if (string.IsNullOrEmpty(setting))
        //        {
        //            return string.Empty;
        //        }

        //        return setting;
        //    }
        //}

        /// <summary>
        /// Gets JavaScript error types from a browser. "SyntaxError,EvalError,ReferenceError,RangeError,TypeError,URIError,Refused to display,Internal Server Error,Cannot read property" by default.
        /// </summary>
        public static Collection<string> JavaScriptErrorTypes
        {
            get
            {

                //setting = ConfigurationManager.AppSettings["JavaScriptErrorTypes"]; //.net4x

                string setting = Builder["appSettings:JavaScriptErrorTypes"]; //.netcore3.x

                //Logger.Info("JavaScript error logging value from settings file '{0}'", setting);
                if (string.IsNullOrEmpty(setting))
                {
                    return new Collection<string>
                    {
                        "SyntaxError",
                        "EvalError",
                        "ReferenceError",
                        "RangeError",
                        "TypeError",
                        "URIError",
                        "Refused to display",
                        "Internal Server Error",
                        "Cannot read property",
                    };
                }

                return new Collection<string>(setting.Split(new char[] { ',' }));
            }
        }

        /// <summary>
        /// Gets the screen shot folder key value.
        /// </summary>
        public static string ScreenShotFolder
        {
            get
            {

                //setting = ConfigurationManager.AppSettings["ScreenShotFolder"]; .net4.x

                string setting = Builder["appSettings:ScreenShotFolder"]; //.netcore3.x

                //Logger.Trace("Get ScreenShotFolder value from settings file '{0}'", setting);
                return setting;
            }
        }

        /// <summary>
        /// Gets a value indicating whether enable AngularJS synchronization. False by default.
        /// </summary>
        public static bool SynchronizationWithAngularEnabled
        {
            get
            {
                //setting = ConfigurationManager.AppSettings["SynchronizationWithAngularEnabled"];

                string setting = Builder["appSettings:SynchronizationWithAngularEnabled"]; //.netcore3.x

                //Logger.Trace("Angular synchronization Enabled value from settings file '{0}'", setting);
                if (string.IsNullOrEmpty(setting))
                {
                    return false;
                }

                if (setting.ToLower(CultureInfo.CurrentCulture).Equals("true"))
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Converting settings from appsettings.json into the NameValueCollection, key - value pairs.
        /// </summary>
        /// <param name="preferences">Section name in appsettings.json file.</param>
        /// <returns>Settings.</returns>
        public static NameValueCollection GetNameValueCollectionFromAppsettings(string preferences)
        {
            NameValueCollection preferencesCollection = new NameValueCollection();
            var jsonSettings = Builder.GetSection(preferences).GetChildren();
          
            if (jsonSettings == null)
            {
                return preferencesCollection;
            }

            foreach (var kvp in jsonSettings)
            {
                string value = null;
                if (kvp.Value != null)
                {
                    value = kvp.Value.ToString();
                }

                preferencesCollection.Add(kvp.Key.ToString(), value);
            }

            return preferencesCollection;
        }

    }
}

