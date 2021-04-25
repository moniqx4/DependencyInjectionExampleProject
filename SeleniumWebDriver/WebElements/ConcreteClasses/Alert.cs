namespace SeleniumWebDriver.WebElements
{
    public class Alert : IAlert
    {
        private readonly IBrowser _browser;
        private readonly IDriverLogger _logger;

        public Alert(IBrowser browser, IDriverLogger logger)
        {
            _browser = browser;
            _logger = logger;
        }

        public IAlert SwitchToAlert()
        {
            _logger.Info("Switching To Alert");
            _browser.SwitchToAlert();

            return this;
        }

        public string GetAlertText()
        {
            _logger.Info("Getting Alert Text");
            return _browser.GetAlertText();
        }

        public IAlert TypeTextInAlert(string text)
        {
            _logger.Info("Typing in Text to Alert", text);
            _browser.SetTextInAlert(text);
            return this;
        }

        public void ClickAlertAcceptButton()
        {
            _logger.Info("Accepting Alert");
            _browser.ClickAlertAcceptButton();
        }

        public void DismissAlert()
        {
            _logger.Info("Dismissing Alert");
            _browser.DismissAlert();
        }

        /* ----- Multiple locators methods -----*/
    }
}
