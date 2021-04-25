using PageObjects.Login;
using PageObjects.Shared;
using System;
using System.Collections.Generic;

namespace AutomationServices.ValidationServices
{  

    public class ValidationService : IValidationService
    {
        private readonly ILoginPage _login;

        public ValidationService(ILoginPage login)
        {
            _login = login;
        }
      
        public void ValidateDataObjectMatch(IList<string> expectedObject, IList<string> actualObject)
        {
            throw new NotImplementedException();
        }

        public void ValidateDateMatch(DateTime expectedDateTime)
        {
            throw new NotImplementedException();
        }

        public void ValidateListMatch(IList<T> ExpectedList)
        {
            throw new NotImplementedException();
        }

        public void ValidateNumberMatch(int expectedNumber)
        {
            throw new NotImplementedException();
        }

        public void ValidateTextContains(string textToCheck, string containingText)
        {
            throw new NotImplementedException();
        }

        public void ValidateTextMatch(string expectedTextValue)
        {
            throw new NotImplementedException();
        }

        public void ValidateTextMatch(string expectedText, string actualText)
        {
            throw new NotImplementedException();
        }
    }
}
