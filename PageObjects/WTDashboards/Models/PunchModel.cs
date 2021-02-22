using PageObjects.WTDashboards.Constants;
using PageObjects.WTDashboards.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WTDashboards.Models
{
    public class PunchModel
    {
        public PunchType PunchType { get; set; }

        public PunchMethod PunchMethod { get; set; }

        public string Notes { get; set; }

        public string PunchDate { get; set; }

        public string PunchStartTime { get; set; }

        public string PunchEndTime { get; set; }

        public IList<string> CostCenters { get; set; }

    }
}
