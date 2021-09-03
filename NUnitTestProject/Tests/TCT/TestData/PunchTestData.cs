using NUnit.Framework;
using System.Collections;


namespace NUnitTestProject.Tests.TCT.TestData
{
    public class PunchTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("value1", "value2", 5, false);
                yield return new TestCaseData("value1", "value2", 5, false);
                yield return new TestCaseData("value1", "value2", 5, false);
                yield return new TestCaseData("value1", "value2", 5, false);
            }
        }
    }
}
