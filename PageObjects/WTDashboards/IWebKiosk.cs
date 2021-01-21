using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WebKiosk
{
    public interface IWebKiosk
    {
        void CreateWebKiosk();

        void LoginToWebKiosk();

        void LogoutOfWebKiosk();

        void StartWebKioskInstance();

        void ConfigWebKiosk();

        void DeleteWebKiosk();

        void HandleTimeOutSessionModal();
    }
}
