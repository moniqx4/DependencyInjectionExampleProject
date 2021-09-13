using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestUtilities
{
    public sealed class ConfigurationService
    {
        private static ConfigurationService _instance;

        public ConfigurationService() => Root = InitializeConfiguration();

        public static ConfigurationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationService();
                }

                return _instance;
            }
        }

        public IConfigurationRoot Root { get; }

        public TestContext Context { get; }

        public static class ConfigurationServiceExtensions
        {
            public static VideoRecordingSettings GetVideoSettings(this ConfigurationService service)
                => ConfigurationService.Instance.Root.GetSection("videoRecordingSettings").Get<VideoRecordingSettings>();
        }

        private IConfigurationRoot InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder();
            if (string.IsNullOrEmpty(ExecutionContext.SettingsFileContent))
            {
                var executionDir = ExecutionDirectoryResolver.GetDriverExecutablePath();
                var filesInExecutionDir = Directory.GetFiles(executionDir);
                var settingsFile =
                    filesInExecutionDir.FirstOrDefault(x => x.Contains("testFrameworkSettings") && x.EndsWith(".json"));
                if (settingsFile != null)
                {
                    builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
                    //builder.Sources.Add<IConfigurationSource>(settingsFile);  //(settingsFile, optional: true, reloadOnChange: true);
                }
            }
            else
            {
                builder.AddJsonStream(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(ExecutionContext.SettingsFileContent)));
            }

            builder.AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
}
