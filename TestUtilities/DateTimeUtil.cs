using System;

namespace TestUtilities
{
    public class DateTimeUtil
    {      
            public DateTime GetCurrentTime() => DateTime.Now;
            public DateTime GetCurrentTimeUtc() => DateTime.UtcNow;       
    }
}
