using System;
using System.Collections.Generic;
using System.Text;

namespace TestUtilities
{
    public static class TimeSpanConverter
    {
        public static TimeSpan Convert(int time, TimeUnit timeUnit)
        {
            TimeSpan result = default;

            switch (timeUnit)
            {
                case TimeUnit.Milliseconds:
                    result = TimeSpan.FromMilliseconds(time);
                    break;
                case TimeUnit.Seconds:
                    result = TimeSpan.FromSeconds(time);
                    break;
                case TimeUnit.Minutes:
                    result = TimeSpan.FromMinutes(time);
                    break;
            }

            return result;
        }

        public enum TimeUnit : byte
        {
            Milliseconds = 0,
            Seconds = 1,
            Minutes = 2,
        }
    }
}
