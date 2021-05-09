using System;
using System.Collections.Generic;
using static AutomationServices.ValidationServices.ValidationService;

namespace AutomationServices.ValidationServices
{
    public interface IValidationService
    {
        void ValidateTextMatch(string expectedTextValue);

        void ValidateDateMatch(DateTime expectedDateTime);

        void ValidateNumberMatch(int expectedNumber);

        void ValidateListMatch(IList<T> ExpectedList);
        

        void ValidateTextMatch(string expectedText, string actualText);

        void ValidateTextContains(string textToCheck, string containingText);

        void ValidateDataObjectMatch(IList<string> expectedObject, IList<string> actualObject);

    }
}
