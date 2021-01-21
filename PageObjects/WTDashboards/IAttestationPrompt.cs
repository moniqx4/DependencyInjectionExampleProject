using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WTDashboards
{
    public interface IAttestationPrompt
    {
        void ResponseToPrompt();

        void CreatePrompt();

        void RemovePrompt();

        void ConfigPrompt();
    }
}
