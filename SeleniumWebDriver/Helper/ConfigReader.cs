﻿using System;
using System.Configuration;

namespace SeleniumWebDriver.Helper
{
    public class ConfigReader
    {
        public ConfigReader()
        {

        }

        public static string GetConfigValue(string keyValue)
        {
            // Read a particular key from the config file 
            var value = ConfigurationManager.AppSettings.Get(keyValue);
            Console.WriteLine("The value of keyValue: " + value);

            return value;
        }
    }
}
