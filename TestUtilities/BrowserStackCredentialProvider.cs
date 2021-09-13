using System;

namespace TestUtilities
{
    public class BrowserStackCredentialProvider : CredentialsProvider
    {
        protected override string UserEnvironmentVariable => "browserstack.user";
        protected override string AccessKeyEnvironmentVariable => "browserstack.accessKey";

        protected override Tuple<string, string> GetCredentialsFromConfig()
        {
            string user = ConfigurationService.Instance.GetMobileSettings().BrowserStack.User;
            string accessKey = ConfigurationService.Instance.GetMobileSettings().BrowserStack.Key;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(accessKey))
            {
                throw new ArgumentException("To use BrowserStack execution you need to set environment variables called (browserstack.user and browserstack.accessKey) or set them in browser settings file.");
            }

            return Tuple.Create(user, accessKey);
        }
    }
}
