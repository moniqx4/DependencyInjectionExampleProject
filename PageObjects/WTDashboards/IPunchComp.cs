using DataModelLibrary;
using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace PageObjects.WTDashboards
{
    public interface IPunchComp
    {

        IPunchComp ClickPunchButton(PunchMethod punchMethod, PunchType punchType);

        IPunchComp ClickManualPunchCostCenterOption();
        IPunchComp ClickManualPunchNoteOption();
        IPunchComp ClickManualPunchTypeOption();
        IPunchComp SetManualPunchCostCenterSearchText(string text);

        IPunchComp SetNotesText(string notes, PunchMethod punchMethod);

        IPunchComp SetCostCenters(List<string> costCenters, PunchMethod punchMethod);
        IPunchComp ClickManualPunchSubmitButton();

    }
}
