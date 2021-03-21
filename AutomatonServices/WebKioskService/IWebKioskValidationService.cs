using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationServices.WebKioskService
{
    interface IWebKioskValidationService
    {
        void ValidatePunchButtonState();

        void ValidatePunchLastActionDisplay();

        void ValidatePunchBadgeState();

        void ValidatePunchCostCenterDisplay();

        void ValidatePunchActivityEntry();
    }
}
