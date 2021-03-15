using Microsoft.Extensions.Configuration;
using System;

namespace TestUtilities
{
    public class DBConnectionStrings
    {
        public static string DBConnectionStr = "";

        //internal static void SetDBConnectionString(Environment testEnvironment = Environment.TIN)
        //{
        //    var config = new ConfigurationBuilder()
        //       .AddJsonFile("AppConfig.json")
        //           .Build();

        //    if (testEnvironment == Environment.TIN) DBConnectionStr = config["TIN"];
        //    else if (testEnvironment == Environment.BRONZE) DBConnectionStr = config["BRONZE"];
        //    else if (testEnvironment == Environment.CARBON) DBConnectionStr = config["CARBON"];
        //    else if (testEnvironment == Environment.DRPROD) DBConnectionStr = config["DRPROD"];
        //}
    }
}
