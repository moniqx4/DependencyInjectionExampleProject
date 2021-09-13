using System;
using System.Collections.Generic;
using System.Text;

namespace TestUtilities
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", string.Empty);

        }
    }
}
