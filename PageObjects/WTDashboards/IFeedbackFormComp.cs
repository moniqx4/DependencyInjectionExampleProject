namespace PageObjects.WTDashboards
{
    public interface IFeedbackFormComp
    {
        IFeedbackFormComp SetTopicTextBox(string topicText);

        IFeedbackFormComp SetFeedbackTextBox(string feedbackText);

        void ClickSubmitButton();
    }
}
