using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.WebKiosk
{
    public interface IWebKioskLoginPage
    {
        IWebKioskLoginPage SetCompanyId(string companyId);

        IWebKioskLoginPage SetUserName(string userName);

        IWebKioskLoginPage SetPassword(string userName);

        void ClickLoginButton();
    }
}
