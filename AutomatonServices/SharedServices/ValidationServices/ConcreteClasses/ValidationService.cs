using System;
using System.Collections.Generic;

namespace AutomationServices.ValidationServices.ConcreteClasses
{  

    public class ValidationService : IValidationService
    {
        

        public ValidationService()
        {           
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

        public class T
        {
        }
    }
}
