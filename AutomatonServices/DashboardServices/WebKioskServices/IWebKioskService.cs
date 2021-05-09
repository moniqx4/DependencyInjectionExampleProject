namespace AutomationServices.WebKioskServices
{
    public interface IWebKioskService
    {
        void CreateWebKioskInstance();

        void ConfigureWebKioskSettings();

        void DeleteWebKiosk();

        void StartUpWebKiosk();

        void ShutdownWebKiosk();

        void ConfigureWebKioskInstance();

        void HandleTimeOutSessionModal();

        void HandlePrompt();

        void HandleTipEntry();

    }
}
