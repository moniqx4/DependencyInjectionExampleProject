using System;
using System.Collections.Generic;
using System.Text;

namespace TestUtilities
{
    public static class ConfigurationSettingsExtensions
    {
        public static MobileSettings GetMobileSettings(this ConfigurationService service)
            => ConfigurationService.Instance.Root.GetSection("mobileSettings").Get<MobileSettings>();
    }
}
