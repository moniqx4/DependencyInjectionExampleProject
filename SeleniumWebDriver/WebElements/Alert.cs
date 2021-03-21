namespace SeleniumWebDriver.WebElements
{
    public class Alert : IAlert
    {
        private readonly IBrowser _browser;
        public Alert(IBrowser browser)
        {
            _browser = browser;
        }

        public IAlert SwitchToAlert()
        {
            _browser.SwitchToAlert();

            return this;
        }

        public string GetAlertText()
        {
            return _browser.GetAlertText();
        }

        public IAlert TypeTextInAlert(string text)
        {
            _browser.SetTextInAlert(text);
            return this;
        }

        public void ClickAlertAcceptButton()
        {
            _browser.ClickAlertAcceptButton();
        }

        public void DismissAlert()
        {
            _browser.DismissAlert();
        }
    }
}
