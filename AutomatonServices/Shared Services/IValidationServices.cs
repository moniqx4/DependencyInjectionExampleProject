using System.Collections.Generic;

namespace AutomationServices.Shared_Services
{  

    public interface IValidationServices
    {
        void ValidateTextMatch(string expectedText, string actualText);

        void ValidateTextContains(string textToCheck, string containingText);

        void ValidateDataObjectMatch(IList<string> expectedObject, IList<string> actualObject);
    }
}
