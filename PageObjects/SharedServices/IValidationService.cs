using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.SharedServices
{
    public interface IValidationService
    {
        bool ValidateTextMatch(string actualText, string expectedText);

        bool ValidateDataObject(List<string> actualDataObject, List<string> expectedDataObject);
    }
}
