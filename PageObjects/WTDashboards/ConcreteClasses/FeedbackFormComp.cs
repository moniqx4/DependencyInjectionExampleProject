using DataModelLibrary;

namespace PageObjects.WTDashboards.ConcreteClasses
{
    public class FeedbackFormComp : BasePageObject, IFeedbackFormComp
    {        

        public void ClickSubmitButton()
        {           
            var locator = SetLocator(LocatorType.CSS, "#feedback-submit");

            HandleClickElement(locator);
        }

        public IFeedbackFormComp SetFeedbackTextBox(string feedbackText)
        {           
            var locator = SetLocator(LocatorType.DataAutomationId, "topic-textfield-input");

            SetTextBox(locator, feedbackText);

            return this;
        }

        public IFeedbackFormComp SetTopicTextBox(string topicText)
        {
            var locator = SetLocator(LocatorType.DataAutomationId, "feedback-textarea-textarea");

            SetTextBox(locator, topicText);

            return this;
        }
    }
}
