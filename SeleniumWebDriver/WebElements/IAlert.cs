namespace SeleniumWebDriver
{
    public interface IAlert
    {
        IAlert SwitchToAlert();

        IAlert TypeTextInAlert(string text);

        string GetAlertText();        

        void ClickAlertAcceptButton();

        void DismissAlert();

    }
}
