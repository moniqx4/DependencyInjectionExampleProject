using System;

namespace TestUtilities
{
    public abstract class CredentialsProvider
    {
        public Tuple<string, string> GetCredentials()
        {
            var user = Environment.GetEnvironmentVariable(UserEnvironmentVariable);
            var accessKey = Environment.GetEnvironmentVariable(AccessKeyEnvironmentVariable);

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(accessKey))
            {
                return Tuple.Create(user, accessKey);
            }

            return GetCredentialsFromConfig();
        }

        protected abstract string UserEnvironmentVariable { get; }
        protected abstract string AccessKeyEnvironmentVariable { get; }
        protected abstract Tuple<string, string> GetCredentialsFromConfig();
    }
}
