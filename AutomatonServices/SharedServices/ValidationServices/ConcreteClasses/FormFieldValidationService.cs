using AutomationServices.SharedServices.ElementActions;
using DataModelLibrary;
using System;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace AutomationServices.SharedServices.ValidationServices.ConcreteClasses
{
    /// <summary>
    ///  Random Generator used is from here: https://github.com/StefH/RandomDataGenerator
    /// </summary>
    public class FormFieldValidationService : IFormFieldValidationService
    {
        private readonly IElementActions _element;

        public FormFieldValidationService(IElementActions element)
        {
            _element = element;
        }

        public bool ValidateTextboxIntegerOnlyAllowedEntry(string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator)
        {
            var integerValues = "1234567890";

            _element.SetText(locator, integerValues);            

            // could do check for Element existing, or being visible and then return true/false
            throw new NotImplementedException();
        }

        public bool ValidateTextboxUnderMinText(int totalCharNum, string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator)
        {
            var text = GenerateText(totalCharNum, DataType.TEXT);
            _element.SetText(locator, text);

            // could do check for Element existing, or being visible and then return true/false
            throw new NotImplementedException();
        }

        public bool ValidateTextboxOverMaxText(int totalCharNum, string expectedErrMessage, BaseLocatorModel locator,BaseLocatorModel errLocator)
        {
            var text1 = GenerateText(25, DataType.TEXT);
            _element.SetText(locator, text1);

            // could do check for Element existing, or being visible and then return true/false
            throw new NotImplementedException();
        }

        public bool ValidateTextboxTextOnlyAllowedEntry(string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator)
        {
            var text1 = GenerateText(25, DataType.INTEGERS);
            _element.SetText(locator, text1);

            // could do check for Element existing, or being visible and then return true/false

            // then 
            var text2 = GenerateText(25, DataType.COMBO);
            _element.SetText(locator, text2);

            // could do check for Element existing, or being visible and then return true/false

            //return the result for both being true/false

            throw new NotImplementedException();
        }

        private string GenerateText(int totalCharNum, DataType dataType)
        {
            //string randomizerText = null;

            switch (dataType)
            {
                case DataType.TEXT:
                    var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsTextLipsum { ValueAsString = true, Seed = totalCharNum });
                    return randomizerText.Generate();
                    
                case DataType.INTEGERS:
                    var randomizerNumbers = RandomizerFactory.GetRandomizer(new FieldOptionsDouble { ValueAsString = true, Seed = totalCharNum });
                    return randomizerNumbers.Generate().ToString();
                    
                case DataType.COMBO:
                    var randomizerChars = RandomizerFactory.GetRandomizer(new FieldOptionsText { ValueAsString = true, Seed = totalCharNum, UseSpecial = true, UseNumber = true });
                    return randomizerChars.Generate().ToString();

                default:
                    throw new Exception("Unknown Data Type");                    
            }          
                        
        }

        private string GetText(BaseLocatorModel locator)
        {
           return _element.GetText(locator);
        }


        private enum DataType
        {
            TEXT,
            INTEGERS,
            COMBO
        }
    }

    internal class T
    {
    }
}
