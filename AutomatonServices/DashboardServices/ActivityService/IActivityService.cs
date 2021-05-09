using DataModelLibrary.WebTimeModels;
using PageObjects.WTDashboards.Models;

namespace AutomationServices.DashboardServices.ActivityService
{
    public interface IActivityService
    {
        AttPointsModel GetAttendencePointDetails();

        PunchActvityModel GetActivityDetails(int index);
    }
}
