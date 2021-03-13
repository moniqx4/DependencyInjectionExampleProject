namespace SeleniumWebDriver
{
    public class EnvironmentConfig
    {
        private static Environment _testEnvironment;

        /// <summary>
        /// Set Environment 
        /// </summary>
        /// <param name="testEnv">Environment to test in</param>
        public static void setTestEnvirnoment(Environment testEnv)
        {
            _testEnvironment = testEnv;
        }

        public static Environment TestEnvironment
        {
            get
            {
                return _testEnvironment;
            }
        }
    }

    /// <summary>
    /// Environment Type
    /// </summary>
    public enum Environment
    {
        TIN,
        BRONZE,
        DRPROD,
        CARBON,
        PROD
    }
}
