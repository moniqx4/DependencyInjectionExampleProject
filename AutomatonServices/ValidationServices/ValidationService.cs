using PageObjects.Login;
using PageObjects.Shared;
using System;
using System.Collections.Generic;

namespace AutomationServices.ValidationServices
{
    /*create interface for all services, and inherit */

    public class ValidationService : IValidationService
    {
        private readonly ILoginPage _login;

        public ValidationService(ILoginPage login)
        {
            _login = login;
        }

        public void Method1()
        {

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

        public void ValidateTextMatch(string expectedTextValue)
        {
            throw new NotImplementedException();
        }
    }
}
