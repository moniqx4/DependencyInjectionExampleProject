using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace TestUtilities
{
    public class JsonReader
    {
        public JsonReader()
        {

        }

        public void GetJson(string jsonText)
        {
            //string jsonText = Generate.SingleJson();

           //TestData webKioskSmokeTest =  JsonConvert.DeserializeObject<TestData>(jsonText);
           // Console.WriteLine(webKioskSmokeTest.SomeData);

            //Create data model of Json data, TestData in above example, then can simply access based on properties of model
        }
    }
}
