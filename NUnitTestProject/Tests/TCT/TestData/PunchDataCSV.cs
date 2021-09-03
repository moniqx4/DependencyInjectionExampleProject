using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NUnitTestProject.Tests.TCT.TestData
{
    public class PunchDataCSV
    {
        public static IEnumerable GetTestCases(string csvFile)
        {
            var csvLines = File.ReadAllLines(csvFile);

            var testCases = new List<TestCaseData>();

            foreach (var line in csvLines)
            {
                string[] values = line.Replace(" ", "").Split(',');

                string someValue = values[0];
                string someValue2 = values[1];

                testCases.Add(new TestCaseData(someValue, someValue2));
            }

            return testCases;
        }
    }
}
