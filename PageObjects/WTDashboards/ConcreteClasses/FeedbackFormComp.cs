using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class FeedbackFormComp : IFeedbackFormComp
    {
        private readonly IWebPage _webPage;
        public FeedbackFormComp(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public void ClickSubmitButton()
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.CSS,
                Locator = "#feedback-submit",
                ElementType = ElementType.Button
            };

            _webPage.ClickElement(locatorModel);
        }

        public IFeedbackFormComp SetFeedbackTextBox(string feedbackText)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "topic-textfield-input",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, feedbackText);

            return this;
        }

        public IFeedbackFormComp SetTopicTextBox(string topicText)
        {
            var locatorModel = new LocatorModel()
            {
                LocatorType = LocatorType.DataAutomationId,
                Locator = "feedback-textarea-textarea",
                ElementType = ElementType.TextBox
            };

            _webPage.SetText(locatorModel, topicText);

            return this;
        }
    }
}
