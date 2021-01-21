using PageObjects.WTDashboards.Models;

namespace PageObjects.WTDashboards
{
    public interface IActivityComp
    {
        AttPointsDto GetAttendencePointDetails();

        PunchActvityDto GetActivityDetails(int index);
    }
}
