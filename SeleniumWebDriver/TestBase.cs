using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver
{
    public class TestBase
    {
        /// <summary>
         /// Take screenshot if test failed and delete cached page objects.
         /// </summary>
         /// <param name="driverContext">The driver context.</param>
         /// <returns>The saved attachements, null if not found.</returns>
        //public string[] SaveTestDetailsIfTestFailed(DriverContext driverContext)
        //{
        //    if (driverContext.IsTestFailed)
        //    {
        //        var screenshots = driverContext.TakeAndSaveScreenshot();
                

        //        var returnList = new List<string>();
        //        returnList.AddRange(screenshots);
              
        //        return returnList.ToArray();
        //    }

        //    return null;
        //}


        /// <summary>
        /// Fail Test If Verify Failed and clear verify messages.
        /// </summary>
        /// <param name="driverContext">Driver context includes.</param>
        /// <returns>True if test failed.</returns>
        //public bool IsVerifyFailedAndClearMessages(DriverContext driverContext)
        //{
        //    if (driverContext.VerifyMessages.Count.Equals(0))
        //    {
        //        return false;
        //    }

        //    driverContext.VerifyMessages.Clear();
        //    return true;
        //}
    }

}
