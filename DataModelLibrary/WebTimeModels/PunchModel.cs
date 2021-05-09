using PageObjects.WTDashboards.Models.Enums;
using System.Collections.Generic;

namespace DataModelLibrary.WebTimeModels
{
    public class PunchModel
    {
        public PunchType PunchType { get; set; }

        public PunchMethod PunchMethod { get; set; }

        public string Notes { get; set; }

        public string PunchDate { get; set; }

        public string PunchStartTime { get; set; }

        public string PunchEndTime { get; set; }

        public List<string> CostCenters { get; set; }

    }
}
