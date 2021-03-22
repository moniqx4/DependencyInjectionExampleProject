namespace AutomationServices.TimeOffService
{
    public interface ITimeoffService
    {
        void CreateTimeOffRequest();

        void GetTimeoffRequestDetails();

        bool DoesPendingTORExist(string benefitType, string benefitStatus);

        void RequestTORForToday(string requestType, string hours);

        bool DoesTORExistInStatusTab(string benefitType, string benefitStatus, int totalHours);

        void DeleteTORRequests(string benefitType, string benefitStatus);

    }
}
