namespace SeleniumWebDriver.Drivers
{
    public class SeleniumCapability
    {
        public SeleniumCapability(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get; }
    }
}
