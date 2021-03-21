using System.Collections.Generic;

namespace NUnitTestProject.Services
{
    public interface IValidationService
    {
        void ValidateTextMatch(string actualText, string expectedText);

        void ValidateDataObject(List<string> actualDataObject, List<string> expectedDataObject);
    }
}
