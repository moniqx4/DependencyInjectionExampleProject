namespace AutomationServices.WebKioskServices
{
    public interface IWebKioskValidationService
    {
        void ValidatePunchButtonState();

        void ValidatePunchLastActionDisplay();

        void ValidatePunchBadgeState();

        void ValidatePunchCostCenterDisplay();

        void ValidatePunchActivityEntry();
    }
}
