using DataModelLibrary.Enums;

namespace SeleniumWebDriver
{
    public class EnvironmentConfig
    {
        private static Environment _testEnvironment;

        /// <summary>
        /// Set Environment 
        /// </summary>
        /// <param name="testEnv">Environment to test in</param>
        public static void SetTestEnvirnoment(Environment testEnv)
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
   
}
