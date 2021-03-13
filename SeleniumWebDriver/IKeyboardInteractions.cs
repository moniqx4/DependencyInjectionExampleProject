namespace SeleniumWebDriver
{
    public interface IKeyboardInteractions
    {
        void SingleCommandKeyAction(string cmdKey, string character);

        void DoubleCommandKeyAction(string cmdKey1, string cmdKey2, string character);

        void SingleCommandKeyAction(string cmdKey, string character1, string character2);
    }
}
