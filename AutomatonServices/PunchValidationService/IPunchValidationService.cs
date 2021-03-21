using PageObjects.WTDashboards.Models;

namespace AutomationServices.PunchValidationService
{
    public interface IPunchValidationService
    {
        void ValidatePunch(PunchModel punch);

        void ValidateLastEntryDisplay();

        void ValidatePunchButtonState();

        void ValidatePunchBadgeState();

        void ValidateCostCenterDisplay();


    }
}
