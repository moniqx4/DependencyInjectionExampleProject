using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject.Services
{
    public class ValidationService : IValidationService
    {
        public void ValidateDataObject(List<string> actualDataObject, List<string> expectedDataObject)
        {
            Assert.AreEqual(actualDataObject, expectedDataObject);
        }


        public void ValidateTextMatch(string actualText, string expectedText)
        {
            Assert.IsTrue(actualText == expectedText);           
        }
    }
}
