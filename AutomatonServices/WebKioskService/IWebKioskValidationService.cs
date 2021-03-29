namespace AutomationServices.WebKioskService
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
