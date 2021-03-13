using System;
using System.Configuration;
using System.Collections.Specialized;

namespace TestUtilities
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
