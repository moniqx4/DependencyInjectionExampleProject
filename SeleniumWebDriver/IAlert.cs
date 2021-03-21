namespace SeleniumWebDriver
{
    public interface IAlert
    {
        IAlert SwitchToAlert();

        string GetAlertText();

        IAlert TypeTextInAlert(string text);

        void ClickAlertAcceptButton();

        void DismissAlert();

    }
}
