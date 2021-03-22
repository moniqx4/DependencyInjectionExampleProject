
namespace PageObjects.WTDashboards
{
    public interface ITimeOffComp
    {
        ITimeOffComp ClickRequestTimeOffButton();

        ITimeOffComp SetStartDateTextBox(string startDate);

        ITimeOffComp SetEndDateTextBox(string endDate);

        ITimeOffComp SetCommentsTextBox(string comments);

        ITimeOffComp SetAvailabilityCheckbox(bool isEnabled);
    }
}
