
using PageObjects.WTDashboards.Models;

namespace PageObjects.WTDashboards
{
    public interface IPunchComp
    {
        IPunchComp AddRegularPunch(PunchModel punchDetails);
        IPunchComp AddManualPunch(PunchModel punchDetails);

        void ClearPunches();
    }
}
