using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Text;
using System;

namespace NUnitTestProject
{
    public class BaseUrl
    {
        public static string Url = "";

        //public static void SetBaseUrl(Environment testEnvironment = Environment.TIN)
        //{
        //    var config = new ConfigurationBuilder()
        //                     .AddJsonFile("AppConfig.json")
        //                     .Build();

        //    if (testEnvironment == Environment.TIN)
        //    {
        //        Url = config["TIN"];
        //    }
        //    else if (testEnvironment == Environment.BRONZE)
        //    {
        //        Url = config["BRONZE"];
        //    }
        //    else if (testEnvironment == Environment.CARBON)
        //    {
        //        Url = config["CARBON"];
        //    }
        //    else if (testEnvironment == Environment.DRPROD)
        //    {
        //        Url = config["DRPROD"];
        //    }
        //}
    }
}
