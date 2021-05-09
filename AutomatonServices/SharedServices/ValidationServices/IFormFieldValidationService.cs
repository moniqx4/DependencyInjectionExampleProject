using DataModelLibrary;

namespace AutomationServices.SharedServices.ValidationServices
{
    public interface IFormFieldValidationService
    {
        bool ValidateTextboxTextOnlyAllowedEntry(string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator);

        bool ValidateTextboxIntegerOnlyAllowedEntry(string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator);

        bool ValidateTextboxOverMaxText(int totalCharNum, string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator);

        bool ValidateTextboxUnderMinText(int totalCharNum, string expectedErrMessage, BaseLocatorModel locator, BaseLocatorModel errLocator);
    }
}
