using PageObjects.Shared;
using System;
using System.Collections.Generic;

namespace AutomationServices.ValidationServices
{
    public interface IValidationService
    {
        void ValidateTextMatch(string expectedTextValue);

        void ValidateDateMatch(DateTime expectedDateTime);

        void ValidateNumberMatch(int expectedNumber);

        void ValidateListMatch(IList<T> ExpectedList);

        //void ValidateObjectMatch(object<T> ExpectedObject);

    }
}
