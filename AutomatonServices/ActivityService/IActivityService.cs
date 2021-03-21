using PageObjects.WTDashboards.Models;

namespace AutomationServices.ActivityService
{
    public interface IActivityService
    {
        AttPointsModel GetAttendencePointDetails();

        PunchActvityModel GetActivityDetails(int index);
    }
}
