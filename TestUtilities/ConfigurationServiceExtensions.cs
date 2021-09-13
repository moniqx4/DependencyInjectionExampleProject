using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace TestUtilities
{
    public static class ConfigurationServiceExtensions
    {
        public static VideoRecordingSettings GetVideoSettings(this ConfigurationService service)
            => ConfigurationService.Instance.Root.GetSection("videoRecordingSettings").Get<VideoRecordingSettings>();
    }
  
}
