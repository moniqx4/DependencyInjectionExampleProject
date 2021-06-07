using DataModelLibrary;
using SeleniumWebDriver;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class FeedbackFormComp : BasePageObject, IFeedbackFormComp
    {
        public FeedbackFormComp(IWebPage webPage) : base(webPage)
        {
        }

        public void ClickSubmitButton()
        {           
            var locator = SetLocator(LocatorType.CSS, "#feedback-submit");

            var element = GetElement(locator);

            element.Click();
        }

        public IFeedbackFormComp SetFeedbackTextBox(string feedbackText)
        {           
            var locator = SetLocator(LocatorType.DataAutomationId, "topic-textfield-input");
            
            var element = GetElement(locator);

            element.SendKeys(feedbackText);

            return this;
        }

        public IFeedbackFormComp SetTopicTextBox(string topicText)
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "feedback-textarea-textarea");

            var element = GetElement(locator);

            element.SendKeys(topicText);

            return this;
        }
    }
}
